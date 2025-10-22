using Clases;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.Entidades
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        public string Descripcion { get; set; }

        // 🔗 Relación uno a uno con Envio
        public Envio Envio { get; set; }

        // 🔗 Relación muchos a muchos con productos
        public ICollection<PedidoProducto> PedidoProductos { get; set; }
    }
}
