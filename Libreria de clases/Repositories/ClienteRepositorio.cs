using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_de_clases.Data;


namespace Libreria_de_clases.Repositories
{
    public class ClienteRepositorio
    {
        private readonly AplicationDbContext _context;

        public ClienteRepositorio(AplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarCliente(Clases.Cliente cliente)
        {
            using (var context = new AplicationDbContext()) 
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        public List<Clases.Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}
