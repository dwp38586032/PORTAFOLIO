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

    [HttpPost("crear")]
    public async Task<IActionResult> crear([FromBody] PedidoModel pedido)
    {
        _pedidosEnMemoria.Add(pedido);

        await _hubContext.Clients.All.SendAsync("RecibirPedido", pedido);



        return Ok(new { message = "Pedido realizado con éxito", pedido });
    }

}

