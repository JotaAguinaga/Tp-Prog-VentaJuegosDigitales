namespace Tienda.Winsform
{
    partial class Form1 : System.Windows.Forms.Form // Ensure Form1 inherits from System.Windows.Forms.Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.TextBox txtBuscarClienteId;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            txtClientes = new TextBox();
            txtBuscarClienteId = new TextBox();
            btnBuscarCliente = new Button();
            btnEliminarCliente = new Button();
            btnRegistrarCliente = new Button();
            SuspendLayout();
            // 
            // txtClientes
            // 
            txtClientes.Location = new Point(20, 60);
            txtClientes.Multiline = true;
            txtClientes.Name = "txtClientes";
            txtClientes.ReadOnly = true;
            txtClientes.ScrollBars = ScrollBars.Vertical;
            txtClientes.Size = new Size(330, 150);
            txtClientes.TabIndex = 0;
            // 
            // txtBuscarClienteId
            // 
            txtBuscarClienteId.Location = new Point(20, 20);
            txtBuscarClienteId.Name = "txtBuscarClienteId";
            txtBuscarClienteId.Size = new Size(80, 23);
            txtBuscarClienteId.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(110, 18);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(60, 27);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(180, 18);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(70, 27);
            btnEliminarCliente.TabIndex = 3;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(260, 18);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(90, 27);
            btnRegistrarCliente.TabIndex = 4;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(464, 352);
            Controls.Add(txtClientes);
            Controls.Add(txtBuscarClienteId);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnRegistrarCliente);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }
        // Add this method to the Form1 class
        private void btnRegistrarCliente_Click(object sender, EventArgs e) =>
            // Implement the logic for registering a client here
            MessageBox.Show("Registrar Cliente button clicked!");
        // Add this method to the Form1 class
        private void btnEliminarCliente_Click(object sender, EventArgs e) =>
            // Implement the logic for deleting a client here
            MessageBox.Show("Eliminar Cliente button clicked!");
        // Add this method to the Form1 class
        private void btnBuscarCliente_Click(object sender, EventArgs e) =>
            // Implement the logic for searching a client here
            MessageBox.Show("Buscar Cliente button clicked!");


        #endregion
    }
}
