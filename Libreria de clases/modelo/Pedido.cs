using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Pedido
{
    public int IdPedido { get; set; }
    public DateTime Fecha { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; }
    public int IdFormaPago { get; set; }
    public FormaPago FormaPago { get; set; }
    public List<PedidoProducto> PedidoProductos { get; set; }
    public Envio Envio { get; set; }
}
