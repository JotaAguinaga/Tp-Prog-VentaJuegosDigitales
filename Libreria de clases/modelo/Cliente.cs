using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;
public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string DNI { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }

    public Cliente(string nombre, string apellido, string dNI, string email, string telefono, string direccion)
    {
        Nombre = nombre;
        Apellido = apellido;
        DNI = dNI;
        Email = email;
        Telefono = telefono;
        Direccion = direccion;
    }
}

