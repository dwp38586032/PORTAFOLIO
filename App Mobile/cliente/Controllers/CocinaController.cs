using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;


    public class CocinaController : Controller
    {
        private readonly ReservaService _reservaService;

        public CocinaController(ReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        public async Task<IActionResult> Cocina()
        {
            var pedidosActivos = await _reservaService.GetPedidosActivosAsync();
            return View(pedidosActivos);
        }


    [HttpPost]
    public async Task<IActionResult> ActualizarEstado(int id)
    {
        string nuevoEstado = await _reservaService.ActualizarEstadoPedidoAsync(id);

        return Json(new { nuevoEstado = nuevoEstado });
    }

    [HttpPost]
    public async Task<IActionResult> RevertirEstado(int id)
    {
        try
        {
            string nuevoEstado = await _reservaService.RevertirEstadoPedidoAsync(id);
            return Json(new { nuevoEstado = nuevoEstado });
        }
        catch (KeyNotFoundException knfex)
        {
            // Manejar el caso en que no se encuentra el pedido
            return NotFound(knfex.Message);
        }
        catch (InvalidOperationException ioex)
        {
            // Manejar otros errores, como estados no reconocidos o no revertibles
            return BadRequest(ioex.Message);
        }
        catch (Exception ex)
        {
            // Manejar errores generales
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

}

