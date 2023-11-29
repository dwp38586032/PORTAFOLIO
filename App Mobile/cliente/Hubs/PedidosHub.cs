using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;




public class PedidosHub : Hub
{
    // Puedes enviar pedidos a todos los clientes conectados sin necesidad de unirlos a un grupo
    public async Task EnviarPedidoATodos(PedidoModel pedido)
    {
        await Clients.All.SendAsync("RecibirPedido", pedido);
    }

    // No necesitas el método JoinRoom a menos que haya alguna otra funcionalidad que lo requiera
}

