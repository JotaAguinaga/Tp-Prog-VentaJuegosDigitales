using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class ProveedorRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public ProveedorRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            _context.SaveChanges();
        }

        public List<Clases.Proveedor> ObtenerTodos()
        {
            return _context.Proveedores.ToList();
        }
    }
}
