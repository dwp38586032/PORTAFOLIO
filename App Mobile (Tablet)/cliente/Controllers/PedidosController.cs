using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Oracle.ManagedDataAccess.Client;
using Microsoft.AspNetCore.Http;

public class PedidosController : Controller
    {

    private readonly IHubContext<PedidosHub> _hubContext;
    private static List<PedidoModel> _pedidosEnMemoria = new List<PedidoModel>();

    public PedidosController(IHubContext<PedidosHub> hubContext)
    {
        _hubContext = hubContext;
    }
 
}


