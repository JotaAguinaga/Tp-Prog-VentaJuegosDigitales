using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Producto
{
    public int IdProducto { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string ClaveDigital { get; set; }
    public int IdProveedor { get; set; }
    public Proveedor Proveedor { get; set; }
}
