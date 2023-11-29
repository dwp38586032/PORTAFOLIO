using Microsoft.AspNetCore.Mvc;


public class OrdenPedidoViewModel
{
    public int Id { get; set; }
    public string Contenido { get; set; }
    public string Estado { get; set; }

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


