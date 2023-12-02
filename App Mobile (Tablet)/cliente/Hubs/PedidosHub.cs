using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;




public class PedidosHub : Hub
{
    public async Task EnviarPedidoATodos(PedidoModel pedido)
    {
        await Clients.All.SendAsync("RecibirPedido", pedido);
    }

}

