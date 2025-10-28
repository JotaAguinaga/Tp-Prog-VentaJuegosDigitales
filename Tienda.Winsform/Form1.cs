using Libreria_de_clases.Repositories;
using Libreria_de_clases.Data;
using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // Asegúrate de que estos controles existan en el diseñador
    // Si no existen, agrégalos en Form1.Designer.cs
    private TextBox txtBuscarClienteId;
    private TextBox txtClientes;
    private Button btnBuscarCliente;
    private Button btnEliminarCliente;
    private Button btnRegistrarCliente;

    public Form1()
    {
        InitializeComponent();

        // Asocia los eventos a los métodos
        btnBuscarCliente.Click += btnBuscarCliente_Click;
        btnEliminarCliente.Click += btnEliminarCliente_Click;
        btnRegistrarCliente.Click += btnRegistrarCliente_Click;
    }

    private void InitializeComponent() => throw new NotImplementedException();

    private void btnBuscarCliente_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtBuscarClienteId.Text, out int id))
        {
            var context = new AplicationDbContext(); // Usa el nombre correcto del archivo
            var repo = new ClienteRepositorio(context);
            var cliente = repo.ObtenerPorId(id);
            if (cliente != null)
                txtClientes.Text = $"ID: {cliente.Id}\r\nNombre: {cliente.Nombre}\r\n";
            else
                txtClientes.Text = "Cliente no encontrado.";
        }
        else
        {
            MessageBox.Show("Ingrese un ID válido.");
        }
    }

    private void btnEliminarCliente_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtBuscarClienteId.Text, out int id))
        {
            var context = new AplicationDbContext(); // Usa el nombre correcto del archivo
            var repo = new ClienteRepositorio(context);
            try
            {
                repo.EliminarCliente(id);
                txtClientes.Text = "Cliente eliminado correctamente.";
            }
            catch (Exception ex)
            {
                txtClientes.Text = $"No se pudo eliminar el cliente. Error: {ex.Message}";
            }
        }
        else
        {
            MessageBox.Show("Ingrese un ID válido.");
        }
    }

    private void btnRegistrarCliente_Click(object sender, EventArgs e) => MessageBox.Show("Abrir formulario para registrar nuevo cliente.");
}
