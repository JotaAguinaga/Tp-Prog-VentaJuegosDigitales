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
        public List<Producto> Productos { get; set; }
        public FormaPago FormaPago { get; set; }
        public Cliente Cliente { get; set; }
    }
}
