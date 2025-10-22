using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class PedidoProductoRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public PedidoProductoRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.PedidoProducto pedidoProducto)
        {
            _context.PedidoProductos.Add(pedidoProducto);
            _context.SaveChanges();
        }

        public List<Clases.PedidoProducto> ObtenerTodos()
        {
            return _context.PedidoProductos.ToList();
        }
    }
}
