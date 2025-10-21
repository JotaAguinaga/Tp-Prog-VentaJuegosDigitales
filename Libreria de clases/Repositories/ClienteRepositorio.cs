using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class ClienteRepositorio
    {
        private readonly Data.AplicationDbContext _context;
        public ClienteRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }
        public void Agregar(Clases.Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public List<Clases.Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }

    }
}
