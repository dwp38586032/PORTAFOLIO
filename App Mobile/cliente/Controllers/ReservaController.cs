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

                // Recuperar el contenido y estado actual antes de añadir los nuevos platos
                string getContenidoQuery = @"
                SELECT CONTENIDO, FECHAHORA
                FROM ORDEN_PEDIDO
                WHERE ID_ORDEN_PEDIDO = :ordenPedidoId FOR UPDATE";
                
                DateTime? fechaHoraActual = null;

                using (var getCommand = new OracleCommand(getContenidoQuery, (OracleConnection)connection))
                {
                    getCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));
                    using (var reader = await getCommand.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            contenidoActual = reader["CONTENIDO"]?.ToString();
                            if (!(reader["FECHAHORA"] is DBNull))
                            {
                                fechaHoraActual = reader.GetDateTime(1); // Asumiendo que FECHAHORA es la segunda columna
                            }
                        }
                    }
                }

                // Convierte la lista de nombres de platos en una cadena separada por comas
                string nuevoContenido = String.Join(", ", nombresPlatos);

                // Si ya existe contenido, añádelo al principio separado por comas
                if (!string.IsNullOrEmpty(contenidoActual))
                {
                    nuevoContenido = contenidoActual + ", " + nuevoContenido;
                }

                // Preparar la consulta SQL para actualizar el registro de ORDEN_PEDIDO
                string updateQuery = @"
                UPDATE ORDEN_PEDIDO 
                SET CONTENIDO = :contenido, 
                    ESTADO = 'pendiente', 
                    FECHAHORA = COALESCE(FECHAHORA, LOCALTIMESTAMP)
                WHERE ID_ORDEN_PEDIDO = :ordenPedidoId";

                using (OracleCommand updateCommand = new OracleCommand(updateQuery, (OracleConnection)connection))
                {
                    // Establecer los parámetros para la consulta
                    updateCommand.Parameters.Add(new OracleParameter("contenido", nuevoContenido));
                    updateCommand.Parameters.Add(new OracleParameter("ordenPedidoId", ordenPedidoId));

                    // Ejecutar la consulta
                    int rowsAffected = await updateCommand.ExecuteNonQueryAsync();

                    if (rowsAffected > 0)
                    {
                        // Si se actualiza al menos una fila, el checkout fue exitoso
                        return Json(new { success = true, message = "Checkout realizado con éxito." });
                    }
                    else
                    {
                        // Si no se actualizan filas, es posible que el ID de la orden no exista
                        return Json(new { success = false, message = "No se encontró la orden de pedido." });
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Manejo de excepciones para capturar cualquier error durante la operación de base de datos
            return Json(new { success = false, message = ex.Message });
        }
    }
    public async Task<IActionResult> EstadoPedido()
    {
        var ordenPedidoId = HttpContext.Session.GetInt32("OrdenPedidoId");
        if (ordenPedidoId.HasValue)
        {
            var viewModel = await _reservaService.GetEstadoPedidoAsync(ordenPedidoId.Value);
            return View("EstadoPedido", viewModel);
        }
        return RedirectToAction("Index"); // o muestra un error
    }

    [HttpGet]
    public async Task<IActionResult> VerificarActualizacion(int pedidoId)
    {
        // Obtén el estado más reciente del pedido desde la base de datos.
        var estadoActual = await _reservaService.ObtenerEstadoActual(pedidoId);

        // Devuelve el estado actual al cliente.
        return Json(new { estado = estadoActual });
    }



}

