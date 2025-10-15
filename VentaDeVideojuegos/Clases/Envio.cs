using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Envio
{
    public int IdEnvio { get; set; }
    public int IdPedido { get; set; }
    public Pedido Pedido { get; set; }
    public string DireccionEntrega { get; set; }
}
