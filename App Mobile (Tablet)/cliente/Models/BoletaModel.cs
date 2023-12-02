using System.Collections.Generic;

public class BoletaModel
{
    public List<ItemBoleta> Items { get; set; }
    public int MontoNeto { get; set; } 
    public int IVA { get; set; } 
    public int Propina { get; set; } 
    public int MontoTotal { get; set; } 

    public BoletaModel()
    {
        Items = new List<ItemBoleta>();
    }
}

public class ItemBoleta
{
    public string Nombre { get; set; }
    public int Precio { get; set; } 
}
