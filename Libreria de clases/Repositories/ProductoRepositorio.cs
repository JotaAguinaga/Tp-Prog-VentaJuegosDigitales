using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class ProductoRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public ProductoRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public List<Clases.Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }
    }
}
