using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Administrador : Empleado
{
    public int IdAdmin { get; set; }
    public string Permisos { get; set; }
}
