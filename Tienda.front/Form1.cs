using System.Data;
using System;
using System.Windows.Forms;
using Libreria_de_clases;
using Clases;
using Libreria_de_clases.Migrations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Libreria_de_clases.Repositories;
using Libreria_de_clases.Data;

namespace Tienda.front
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Cliente dato = new Cliente();
        private ClienteRepositorio clienteRepo = new ClienteRepositorio();
        private object dataGridViewClientes;
        private ClienteRepositorio _repo;

        public Form1()
        {
            InitializeComponent();
            Iniciar();
            _repo = new ClienteRepositorio(new AplicationDbContext());
        }

        private void btnguardarcliente_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Email = txtcorreo.Text,
            };

            _repo.Agregar(nuevoCliente);
            MessageBox.Show("Cliente guardado con éxito");

            CargarClientes(); // refresca la lista
        }


        private void CargarClientes()
        {
            var lista = ClienteRepositorio();
            datalista.DataSource = lista;
        }

        private object ClienteRepositorio()
        {
           Cliente nuevoCliente = new Cliente     
 
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Direccion = string.IsNullOrWhiteSpace(txtcorreo.Text) ? null : txtcorreo.Text,
            };

            _repo.Agregar(nuevoCliente);

            MessageBox.Show("Cliente guardado con éxito");
            CargarClientes();
        }
        
      

        private void btneliminarcliente_Click(object sender, EventArgs e)
        {
            EliminarCliente();

        }

        private DataTable Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Correo");
            datalista.DataSource = tabla;
            return tabla;
        }

        public void GuardarCliente(Cliente cliente)
        {
            //Alta cliente 

            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Correo");

            Cliente dato = new Cliente
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Email = txtcorreo.Text,
                Id = int.Parse(txtid.Text),
                DNI = null,
                Telefono = null,
                Direccion = null
            };
            dato.GuardarCliente(cliente);

        }
        public void ConsultarCliente()
        {
            var clientes = dato.ObtenerTodos();
            foreach (Cliente cliente in clientes)
            {
                tabla.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Email);
            }
        }

        public void EliminarCliente()
        {
            int id = int.Parse(txtid.Text);
            {
                //Baja cliente
                dato.EliminarCliente(id);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}