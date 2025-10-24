using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Producto
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string ClaveDigital { get; set; }
    public Proveedor Proveedor { get; set; }

    public Producto(string Nombre, decimal Precio, int Stock, string ClaveDigital) 
    {
        Nombre = Nombre;
        Precio = Precio;
        Stock = Stock;
        ClaveDigital = ClaveDigital;
    }
}
