using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class PersonaRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public PersonaRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.Persona persona)
        {
            _context.Personas.Add(persona);
            _context.SaveChanges();
        }

        public List<Clases.Persona> ObtenerTodos()
        {
            return _context.Personas.ToList();
        }
    }
}
