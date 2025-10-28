using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class FormaPagoRepositorio
    {
        private readonly Data.AplicationDbContext _context;

        public FormaPagoRepositorio(Data.AplicationDbContext context)
        {
            _context = context;
        }

        public void Agregar(Clases.FormaPago formaPago)
        {
            _context.FormasPago.Add(formaPago);
            _context.SaveChanges();
        }

        public List<Clases.FormaPago> ObtenerTodos() => _context.FormasPago.ToList();
    }
}
