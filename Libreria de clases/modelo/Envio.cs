using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.Entidades
{
    public class Envio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string DireccionEntrega { get; set; }

        // 🔗 Relación 1 a 1 con Pedido
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}
