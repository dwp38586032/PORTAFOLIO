using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Types;
using System.Collections.Generic;

public class ReservaService
    {
        private readonly OracleDatabaseService _databaseService;

        public ReservaService(OracleDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

    public async Task<bool> ExisteCodigoReservaAsync(string codigoReserva)
    {
        using (var connection = _databaseService.CreateConnection())
        {

            connection.Open();
            string query = "SELECT COUNT(*) FROM RESERVA WHERE CODIGO = :codigoReserva";
            using (var command = new OracleCommand(query, (OracleConnection)connection))
            {
                command.Parameters.Add(new OracleParameter("codigoReserva", codigoReserva));

                var result = await command.ExecuteScalarAsync();
                return Convert.ToInt32(result) > 0;
            }
        }
    }

    public async Task<List<OrdenPedidoViewModel>> GetPedidosActivosAsync()
    {
        List<OrdenPedidoViewModel> pedidosActivos = new List<OrdenPedidoViewModel>();

        using (var connection = _databaseService.CreateConnection())
        {

            connection.Open();
            string query = "SELECT * FROM ORDEN_PEDIDO WHERE ESTADO != 'Pagado'";

            using (var command = new OracleCommand(query, (OracleConnection)connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var pedido = new OrdenPedidoViewModel
                        {
                            Id = reader.GetInt32("ID_ORDEN_PEDIDO"),
                            Contenido = reader.GetString("CONTENIDO"),
                            Estado = reader.GetString("ESTADO"),
                            
                           
                        };
                        pedidosActivos.Add(pedido);
                    }
                }
            }
        }

        return pedidosActivos;
    }



    public async Task<int> CrearOrdenPedidoAsync(string codigoReserva)
    {
        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            // Inicia una transacción
            using (OracleTransaction transaction = (OracleTransaction)connection.BeginTransaction())
            {
                string query = @"
                INSERT INTO ORDEN_PEDIDO (CONTENIDO) VALUES ('')
                RETURNING ID_ORDEN_PEDIDO INTO :ordenPedidoId";

                using (var command = new OracleCommand(query, (OracleConnection)connection))
                {
                    command.Transaction = transaction;

                    var ordenPedidoIdParam = new OracleParameter
                    {
                        ParameterName = "ordenPedidoId",
                        OracleDbType = OracleDbType.Int32,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(ordenPedidoIdParam);

                    await command.ExecuteNonQueryAsync();

                    transaction.Commit(); // Confirma la transacción

                    // Convierte el OracleDecimal a int
                    OracleDecimal oracleDecimalValue = (OracleDecimal)ordenPedidoIdParam.Value;
                    int ordenPedidoId = oracleDecimalValue.ToInt32();

                    return ordenPedidoId;
                }
            }
        }
    }

    public async Task<EstadoPedidoViewModel> GetEstadoPedidoAsync(int ordenPedidoId)
    {
        EstadoPedidoViewModel viewModel = new EstadoPedidoViewModel
        {
            Items = new List<ItemPedido>()
        };

        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            // Obtener el estado de la orden
            string estadoQuery = "SELECT ESTADO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";
            using (var estadoCommand = new OracleCommand(estadoQuery, (OracleConnection)connection))
            {
                estadoCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                viewModel.Estado = (await estadoCommand.ExecuteScalarAsync())?.ToString();
            }

            // Obtener los artículos de la orden
            string itemsQuery = "SELECT CONTENIDO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";
            using (var itemsCommand = new OracleCommand(itemsQuery, (OracleConnection)connection))
            {
                itemsCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                using (var reader = await itemsCommand.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        // Suponiendo que CONTENIDO es una lista separada por comas de nombres de platos
                        string contenido = reader["CONTENIDO"]?.ToString();
                        if (!string.IsNullOrEmpty(contenido))
                        {
                            var nombresPlatos = contenido.Split(',');
                            foreach (var nombre in nombresPlatos)
                            {
                                string itemQuery = "SELECT PRECIO FROM PLATO WHERE NOMBRE = :nombre";
                                using (var itemCommand = new OracleCommand(itemQuery, (OracleConnection)connection))
                                {
                                    itemCommand.Parameters.Add(new OracleParameter("nombre", nombre.Trim()));

                                    // Obtener el precio del plato
                                    var precio = await itemCommand.ExecuteScalarAsync();
                                    decimal precioDecimal = precio != null ? Convert.ToDecimal(precio) : 0;

                                    viewModel.Items.Add(new ItemPedido
                                    {
                                        Nombre = nombre.Trim(),
                                        Precio = precioDecimal
                                    });
                                }
                            }
                        }


                    }

                }
            }


        }

        return viewModel;
    }


    public async Task<string> ActualizarEstadoPedidoAsync(int id)
    {
        // Obtener el pedido actual de la base de datos
        var pedido = await _databaseService.ObtenerPedidoPorIdAsync(id); // Este método necesita ser implementado

        // Verificar el estado actual y actualizarlo
        switch (pedido.Estado)
        {
            case "pendiente":
                pedido.Estado = "cocinando";
                break;
            case "cocinando":
                pedido.Estado = "sirviendo";
                break;
            // Puedes manejar más casos si es necesario
            default:
                throw new InvalidOperationException("Estado no reconocido");
        }

        // Guardar el cambio en la base de datos
        await _databaseService.ActualizarPedidoAsync(pedido); // Este método necesita ser implementado

        // Devolver el nuevo estado
        return pedido.Estado;
    }

    public async Task<string> RevertirEstadoPedidoAsync(int id)
    {
        // Obtener el pedido actual de la base de datos
        var pedido = await _databaseService.ObtenerPedidoPorIdAsync(id);
        if (pedido == null)
        {
            throw new KeyNotFoundException("Pedido no encontrado con el ID especificado.");
        }

        // Verificar el estado actual y revertirlo
        switch (pedido.Estado)
        {
            case "sirviendo":
                pedido.Estado = "cocinando";
                break;
            case "cocinando":
                pedido.Estado = "pendiente";
                break;
            // Manejar otros casos si es necesario
            default:
                throw new InvalidOperationException("Estado no reconocido o no se puede revertir.");
        }

        // Guardar el cambio en la base de datos
        bool actualizado = await _databaseService.ActualizarPedidoAsync(pedido);
        if (!actualizado)
        {
            throw new Exception("No se pudo actualizar el estado del pedido.");
        }

        // Devolver el nuevo estado
        return pedido.Estado;
    }
    public async Task<string> ObtenerEstadoActual(int pedidoId)
    {
        // Asegúrate de que la conexión a la base de datos está configurada correctamente
        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            string query = "SELECT ESTADO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :pedidoId";

            using (var command = new OracleCommand(query, (OracleConnection)connection))
            {
                // Asegúrate de que la inyección de dependencias para OracleDatabaseService está configurada correctamente
                // para que _databaseService.CreateConnection() cree una conexión válida.

                // Configura el parámetro para evitar la inyección SQL
                command.Parameters.Add(new OracleParameter("pedidoId", pedidoId));

                // Ejecuta la consulta y lee el resultado
                var result = await command.ExecuteScalarAsync();
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    // Decide cómo quieres manejar el caso de que no se encuentre el pedido
                    // Por ejemplo, podrías devolver un estado predeterminado o lanzar una excepción
                    return "No encontrado"; // O manejar de otra manera
                }
            }
        }
    }




}

