using Libreria_de_clases.Data;
using System.Collections.Generic;
using System.Linq;

namespace Libreria_de_clases.Repositories
{
    public class EmpleadoRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public EmpleadoRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public List<Clases.Empleado> ObtenerTodos()
        {
            return _context.Empleados.ToList();
        }
    }
}
