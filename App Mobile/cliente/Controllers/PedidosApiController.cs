using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR;

using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


[Route("api/[controller]")]
[ApiController]
public class PedidosApiController : ControllerBase
{
    private readonly IHubContext<PedidosHub> _hubContext;
    private static List<PedidoModel> _pedidosEnMemoria = new List<PedidoModel>();

    public PedidosApiController(IHubContext<PedidosHub> hubContext)
    {
        _hubContext = hubContext;
    }

    // POST: api/PedidosApi
    [HttpPost("crear")]
    public async Task<IActionResult> crear([FromBody] PedidoModel pedido)
    {
        // Añadir el pedido a una lista en memoria
        _pedidosEnMemoria.Add(pedido);

        // Enviar la información del pedido a la vista de la cocina usando SignalR
        await _hubContext.Clients.All.SendAsync("RecibirPedido", pedido);



        // Devolver una respuesta de éxito
        return Ok(new { message = "Pedido realizado con éxito", pedido });
    }

    // Aquí podrías añadir más métodos API, como obtener un pedido, listar todos los pedidos, etc.
}

