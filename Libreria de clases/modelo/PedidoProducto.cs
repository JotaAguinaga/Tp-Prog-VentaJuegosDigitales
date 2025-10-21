using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class PedidoProducto
{
    public int IdPedido { get; set; }
    public Pedido Pedido { get; set; }
    public int IdProducto { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
}
