using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class EnvioRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public EnvioRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.Envio envio)
        {
            _context.Envios.Add(envio);
            _context.SaveChanges();
        }

        public List<Clases.Envio> ObtenerTodos()
        {
            return _context.Envios.ToList();
        }
    }
}
