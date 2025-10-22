using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Empleado : Persona
{
    public int Id { get; set; }
    public string Cargo { get; set; }
    public decimal Sueldo { get; set; }
}
