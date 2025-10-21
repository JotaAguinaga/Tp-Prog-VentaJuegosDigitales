using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Cliente : Persona
{
    public int IdCliente { get; set; }
    public string Direccion { get; set; }
    public string TipoCliente { get; set; }
}

