using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class PedidoRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public PedidoRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public List<Clases.Pedido> ObtenerTodos()
        {
            return _context.Pedidos.ToList();
        }
    }
}
