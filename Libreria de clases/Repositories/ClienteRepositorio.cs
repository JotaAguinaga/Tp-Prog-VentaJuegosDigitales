using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
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

        public ClienteRepositorio()
        {
        }

        // 🔹 Alta (Agregar cliente)
        public void Agregar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // 🔹 Baja (Eliminar cliente)
        public void Eliminar(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

        // 🔹 Listar todos
        public List<Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }

        // 🔹 Buscar por ID
        public Cliente ObtenerPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }
    }
}
