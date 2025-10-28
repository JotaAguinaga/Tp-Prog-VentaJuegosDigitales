using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_de_clases.Data;

namespace Clases;
public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string? DNI { get; set; }
    public string Email { get; set; }
    public string? Telefono { get; set; }
    public string? Direccion { get; set; }

    //public object? Dni { get; set; }

    public Cliente(int ID,string nombre, string apellido, string? dNI, string email, string? telefono, string? direccion)
    {
        Id = ID;
        Nombre = nombre;
        Apellido = apellido;
        DNI = dNI;
        Email = email;
        Telefono = telefono;
        Direccion = direccion;
    }

    public Cliente()
    {

    }

    public void GuardarCliente(Cliente cliente)
    {
        using (var context = new AplicationDbContext())
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
    }
        

    public IEnumerable<object> ObtenerTodos()
    {
        throw new NotImplementedException();
    }

    public void EliminarCliente(int id)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Cliente(DataTable v)
    {
        throw new NotImplementedException();
    }
}

