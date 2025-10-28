using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.WinForms
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox txtBuscarClienteId;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
            // txtBuscarClienteId
            // 
            this.txtBuscarClienteId = new System.Windows.Forms.TextBox();
            this.txtBuscarClienteId.Location = new System.Drawing.Point(20, 20);
            this.txtBuscarClienteId.Name = "txtBuscarClienteId";
            this.txtBuscarClienteId.Size = new System.Drawing.Size(120, 20);
            this.txtBuscarClienteId.TabIndex = 0;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente.Location = new System.Drawing.Point(150, 18);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnRegistrarCliente.Location = new System.Drawing.Point(230, 18);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(120, 23);
            this.btnRegistrarCliente.TabIndex = 2;
            this.btnRegistrarCliente.Text = "Registrar Nuevo";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);

            // Agrega los controles al formulario
            this.Controls.Add(this.txtBuscarClienteId);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnRegistrarCliente);
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // Aquí puedes buscar el cliente por ID usando tu repositorio
            int id;
            if (int.TryParse(txtBuscarClienteId.Text, out id))
            {
                // Ejemplo: var cliente = clienteRepositorio.ObtenerPorId(id);
                // Muestra los datos o un mensaje si no existe
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            // Aquí puedes abrir un formulario para registrar un nuevo cliente
            // Ejemplo: new FormRegistrarCliente().ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
