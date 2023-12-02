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

                    transaction.Commit(); 

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

            string estadoQuery = "SELECT ESTADO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";
            using (var estadoCommand = new OracleCommand(estadoQuery, (OracleConnection)connection))
            {
                estadoCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                viewModel.Estado = (await estadoCommand.ExecuteScalarAsync())?.ToString();
            }

            string itemsQuery = "SELECT CONTENIDO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";
            using (var itemsCommand = new OracleCommand(itemsQuery, (OracleConnection)connection))
            {
                itemsCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                using (var reader = await itemsCommand.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
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
        var pedido = await _databaseService.ObtenerPedidoPorIdAsync(id); 

        switch (pedido.Estado)
        {
            case "pendiente":
                pedido.Estado = "cocinando";
                break;
            case "cocinando":
                pedido.Estado = "sirviendo";
                break;
            default:
                throw new InvalidOperationException("Estado no reconocido");
        }

        await _databaseService.ActualizarPedidoAsync(pedido);

        return pedido.Estado;
    }

    public async Task<string> RevertirEstadoPedidoAsync(int id)
    {
        var pedido = await _databaseService.ObtenerPedidoPorIdAsync(id);
        if (pedido == null)
        {
            throw new KeyNotFoundException("Pedido no encontrado con el ID especificado.");
        }

        switch (pedido.Estado)
        {
            case "sirviendo":
                pedido.Estado = "cocinando";
                break;
            case "cocinando":
                pedido.Estado = "pendiente";
                break;
            default:
                throw new InvalidOperationException("Estado no reconocido o no se puede revertir.");
        }

        bool actualizado = await _databaseService.ActualizarPedidoAsync(pedido);
        if (!actualizado)
        {
            throw new Exception("No se pudo actualizar el estado del pedido.");
        }

        return pedido.Estado;
    }
    public async Task<string> ObtenerEstadoActual(int pedidoId)
    {
        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            string query = "SELECT ESTADO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :pedidoId";

            using (var command = new OracleCommand(query, (OracleConnection)connection))
            {

                command.Parameters.Add(new OracleParameter("pedidoId", pedidoId));

                var result = await command.ExecuteScalarAsync();
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    return "No encontrado"; 
                }
            }
        }
    }

    public async Task<List<ItemBoleta>> ObtenerItemsDeLaBoleta(int ordenPedidoId)
    {
        var itemsDeLaBoleta = new List<ItemBoleta>();

        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            string queryDetalleOrden = @"
            SELECT ID_PLATO 
            FROM detalle_orden 
            WHERE ID_ORDEN_PEDIDO = :OrdenPedidoId";

            using (var command = new OracleCommand(queryDetalleOrden, (OracleConnection)connection))
            {
                command.Parameters.Add(new OracleParameter("OrdenPedidoId", ordenPedidoId));

                using (var reader = await command.ExecuteReaderAsync())
                {
                    var listaIdPlato = new List<int>();
                    while (await reader.ReadAsync())
                    {
                        listaIdPlato.Add(reader.GetInt32(0));
                    }

                    foreach (var idPlato in listaIdPlato)
                    {
                        string queryPlato = @"
                        SELECT NOMBRE, PRECIO 
                        FROM plato 
                        WHERE ID_PLATO = :IdPlato";

                        using (var platoCommand = new OracleCommand(queryPlato, (OracleConnection)connection))
                        {
                            platoCommand.Parameters.Add(new OracleParameter("IdPlato", idPlato));

                            using (var platoReader = await platoCommand.ExecuteReaderAsync())
                            {
                                if (await platoReader.ReadAsync())
                                {
                                    itemsDeLaBoleta.Add(new ItemBoleta
                                    {
                                        Nombre = platoReader.GetString(0),
                                        Precio = platoReader.GetInt32(1)
                                    });
                                }
                            }
                        }
                    }
                }
            }
        }

        return itemsDeLaBoleta;
    }

 
    public async Task<EstadoPedidoViewModel> GetEstadoPedidoAsync1(int ordenPedidoId)
    {
        EstadoPedidoViewModel viewModel = new EstadoPedidoViewModel
        {
            Items = new List<ItemPedido>()
        };

        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            string estadoQuery = "SELECT ESTADO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";
            using (var estadoCommand = new OracleCommand(estadoQuery, (OracleConnection)connection))
            {
                estadoCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                viewModel.Estado = (await estadoCommand.ExecuteScalarAsync())?.ToString();
            }
            string itemsQuery = "SELECT CONTENIDO FROM ORDEN_PEDIDO WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";
            using (var itemsCommand = new OracleCommand(itemsQuery, (OracleConnection)connection))
            {
                itemsCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                using (var reader = await itemsCommand.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
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

            string propinaQuery = @"
            SELECT b.PROPINA
            FROM BOLETA b
            INNER JOIN ORDEN_PEDIDO o ON b.ID_BOLETA = o.ID_BOLETA
            WHERE o.ID_ORDEN_PEDIDO = :ordenPedidoId";
            using (var propinaCommand = new OracleCommand(propinaQuery, (OracleConnection)connection))
            {
                propinaCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));

                var propinaResult = await propinaCommand.ExecuteScalarAsync();
                if (propinaResult != null && propinaResult != DBNull.Value)
                {
                    viewModel.Propina = Convert.ToInt32(propinaResult);
                }
            }
        }

        return viewModel;
    }

}

