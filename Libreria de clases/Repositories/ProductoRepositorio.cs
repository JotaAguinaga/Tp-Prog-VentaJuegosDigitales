using Libreria_de_clases.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Repositories
{
    public class ProductoRepositorio
    {
        public ProductoRepositorio(AplicationDbContext aplicationDbContext)
        {
        }

        public void AgregarProducto(Clases.Producto producto)
        {
            using (var context = new AplicationDbContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }

        public void MostrarProducto(Clases.Producto producto)
        {
            using (var context = new AplicationDbContext()) 
            { 
                context.Productos.ToList();
            }
        }
    }
}
