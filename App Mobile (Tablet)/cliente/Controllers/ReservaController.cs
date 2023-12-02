using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

public class ReservaController : Controller
{
    private readonly ReservaService _reservaService;
    private readonly OracleDatabaseService _databaseService;

    
    public ReservaController(ReservaService reservaService, OracleDatabaseService databaseService)
    {
        _reservaService = reservaService;
        _databaseService = databaseService;
    }

    [HttpPost]
        public async Task<IActionResult> VerificarYCrearOrdenPedido(string codigoReserva)
        {

            if (await _reservaService.ExisteCodigoReservaAsync(codigoReserva))
            {
            int ordenPedidoId = await _reservaService.CrearOrdenPedidoAsync(codigoReserva);

            HttpContext.Session.SetInt32("OrdenPedidoId", ordenPedidoId);

            return Json(new { OrdenPedidoId = ordenPedidoId });
            }
            else
            {
                return Json(new { Error = "Código de reserva no válido." });
            }
        }

    [HttpPost]
    public async Task<IActionResult> RealizarCheckout(int ordenPedidoId, List<string> nombresPlatos)
    {
        try
        {
            using (var connection = _databaseService.CreateConnection())
            {
                connection.Open();
                string contenidoActual = string.Empty;
                using (OracleTransaction transaction = (OracleTransaction)connection.BeginTransaction())
                {
                    

                    string getContenidoQuery = @"
                    SELECT CONTENIDO, FECHAHORA
                    FROM ORDEN_PEDIDO
                    WHERE ID_ORDEN_PEDIDO = :ordenPedidoId FOR UPDATE";

                    DateTime? fechaHoraActual = null;

                    using (var getCommand = new OracleCommand(getContenidoQuery, (OracleConnection)connection))
                    {
                        getCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                        getCommand.Transaction = transaction; 

                        using (var reader = await getCommand.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                contenidoActual = reader["CONTENIDO"]?.ToString();
                                if (!(reader["FECHAHORA"] is DBNull))
                                {
                                    fechaHoraActual = reader.GetDateTime(1); 
                                }
                            }
                        }
                    }

                    string nuevoContenido = string.Join(", ", nombresPlatos);

                    if (!string.IsNullOrEmpty(contenidoActual))
                    {
                        nuevoContenido = contenidoActual + ", " + nuevoContenido;
                    }

                    string updateQuery = @"
                    UPDATE ORDEN_PEDIDO 
                    SET CONTENIDO = :contenido, 
                        ESTADO = 'pendiente', 
                        FECHAHORA = COALESCE(FECHAHORA, LOCALTIMESTAMP)
                    WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";

                    using (OracleCommand updateCommand = new OracleCommand(updateQuery, (OracleConnection)connection))
                    {
                        updateCommand.Parameters.Add(new OracleParameter("contenido", nuevoContenido));
                        updateCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                        updateCommand.Transaction = transaction; 

                        int rowsAffected = await updateCommand.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            List<int> platosIds = await ConvertirNombresAIds(nombresPlatos);

                            foreach (var platoId in platosIds)
                            {
                                string insertDetalleOrdenQuery = @"
                                INSERT INTO DETALLE_ORDEN (ID_ORDEN_PEDIDO, ID_PLATO, CANTIDAD)
                                VALUES (:ordenPedidoId, :platoId, 1)"; 

                                using (OracleCommand insertCommand = new OracleCommand(insertDetalleOrdenQuery, (OracleConnection)connection))
                                {
                                    insertCommand.Transaction = transaction; 
                                    insertCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                                    insertCommand.Parameters.Add(new OracleParameter("platoId", platoId));
                                    await insertCommand.ExecuteNonQueryAsync();
                                }
                            }
                            await transaction.CommitAsync();

                            return Json(new { success = true, message = "Checkout realizado con éxito." });
                        }
                        else
                        {
                            await transaction.RollbackAsync();
                            return Json(new { success = false, message = "No se encontró la orden de pedido." });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }


    public async Task<List<int>> ConvertirNombresAIds(List<string> nombresPlatos)
    {
        List<int> platosIds = new List<int>();
        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            string getIdsQuery = @"
            SELECT ID_PLATO FROM PLATO WHERE NOMBRE = :nombre";

            foreach (string nombrePlato in nombresPlatos)
            {
                using (OracleCommand getIdsCommand = new OracleCommand(getIdsQuery, (OracleConnection)connection))
                {
                    getIdsCommand.Parameters.Add(new OracleParameter("nombre", nombrePlato));

                    using (var reader = await getIdsCommand.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            platosIds.Add(reader.GetInt32(0)); 
                        }
                    }
                }
            }
        }

        return platosIds;
    }

    public async Task<IActionResult> EstadoPedido()
    {
        var ordenPedidoId = HttpContext.Session.GetInt32("OrdenPedidoId");
        if (ordenPedidoId.HasValue)
        {
            var viewModel = await _reservaService.GetEstadoPedidoAsync(ordenPedidoId.Value);
            return View("EstadoPedido", viewModel);
        }
        return RedirectToAction("Index"); 
    }


    public async Task<IActionResult> Gracias()
    {
        var ordenPedidoId = HttpContext.Session.GetInt32("OrdenPedidoId");
        if (ordenPedidoId.HasValue)
        {
            var viewModel = await _reservaService.GetEstadoPedidoAsync1(ordenPedidoId.Value);
            return View("Gracias", viewModel);
        }
        return RedirectToAction("Index", "Home");
    }





    [HttpGet]
    public async Task<IActionResult> VerificarActualizacion(int pedidoId)
    {
        var estadoActual = await _reservaService.ObtenerEstadoActual(pedidoId);

        return Json(new { estado = estadoActual });
    }


    [HttpPost]
    public async Task<IActionResult> CrearBoleta(int ordenPedidoId, int totalEnCLP, int propina)
    {
        decimal iva = totalEnCLP * 0.19m; 
        decimal montoTotal = totalEnCLP + iva + propina;
        DateTime fechaActual = DateTime.Now;

        using (var connection = _databaseService.CreateConnection())
        {
            connection.Open();

            using (OracleTransaction transaction = (OracleTransaction)connection.BeginTransaction())
            {
                string insertBoletaQuery = @"
                INSERT INTO BOLETA (MONTO_NETO, FECHA, IVA, MONTO_TOTAL, PROPINA) 
                VALUES (:TotalEnCLP, :Fecha, :Iva, :MontoTotal, :propina)
                RETURNING ID_BOLETA INTO :idBoleta";

                using (var command = new OracleCommand(insertBoletaQuery, (OracleConnection)connection))
                {
                    command.Transaction = transaction;

                    command.Parameters.Add(new OracleParameter("TotalEnCLP", totalEnCLP));
                    command.Parameters.Add(new OracleParameter("Fecha", fechaActual));
                    command.Parameters.Add(new OracleParameter("Iva", iva));
                    command.Parameters.Add(new OracleParameter("MontoTotal", montoTotal));
                    command.Parameters.Add(new OracleParameter("propina", propina));

                    var idBoletaParam = new OracleParameter
                    {
                        ParameterName = "idBoleta",
                        OracleDbType = OracleDbType.Int32,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(idBoletaParam);

                    await command.ExecuteNonQueryAsync();

                    int idBoleta = Convert.ToInt32(idBoletaParam.Value.ToString());



                    string updateOrdenPedidoQuery = @"
    UPDATE ORDEN_PEDIDO 
    SET ID_BOLETA = :idBoleta, 
        ESTADO = 'Pagado' 
    WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";

                    using (var updateCommand = new OracleCommand(updateOrdenPedidoQuery, (OracleConnection)connection))
                    {
                        updateCommand.Transaction = transaction;
                        updateCommand.Parameters.Add(new OracleParameter("idBoleta", idBoleta));
                        updateCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));

                        await updateCommand.ExecuteNonQueryAsync();
                    }


                    transaction.Commit(); 

                    return Ok(new { message = "Boleta creada con éxito y asociada a la orden de pedido", boletaId = idBoleta });
                }
            }
        }
    }




}

