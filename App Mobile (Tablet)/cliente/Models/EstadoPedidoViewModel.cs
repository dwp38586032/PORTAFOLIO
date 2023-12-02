using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class EstadoPedidoViewModel
{
    public List<ItemPedido> Items { get; set; }
    public string Estado { get; set; }
    public int Propina { get; set; }

    public int GetProgressValue()
    {
        return Estado switch
        {
            "pendiente" => 30,
            "cocinando" => 60,
            "sirviendo" => 90,
            _ => 0
        };
    }
}

public class ItemPedido
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}

