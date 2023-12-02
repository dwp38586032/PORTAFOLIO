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
            return NotFound(knfex.Message);
        }
        catch (InvalidOperationException ioex)
        {
            return BadRequest(ioex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

}

