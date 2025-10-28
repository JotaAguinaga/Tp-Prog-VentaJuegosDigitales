namespace Tienda.front
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            label3 = new Label();
            txtapellido = new TextBox();
            txtcorreo = new TextBox();
            label5 = new Label();
            btnguardarcliente = new Button();
            datalista = new DataGridView();
            btneliminarcliente = new Button();
            label6 = new Label();
            btnPedidos = new Button();
            btnsiguiente = new Button();
            TITULO = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)datalista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 13;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 12;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(74, 18);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 21);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "APELLIDO";
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(246, 18);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(130, 23);
            txtapellido.TabIndex = 4;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(71, 55);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(205, 23);
            txtcorreo.TabIndex = 7;
            txtcorreo.Text = "Ingrese su correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 58);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "CORREO";
            // 
            // btnguardarcliente
            // 
            btnguardarcliente.Location = new Point(74, 103);
            btnguardarcliente.Name = "btnguardarcliente";
            btnguardarcliente.Size = new Size(111, 23);
            btnguardarcliente.TabIndex = 9;
            btnguardarcliente.Text = "Registrar Cliente";
            btnguardarcliente.UseVisualStyleBackColor = true;
            btnguardarcliente.Click += btnguardarcliente_Click;
            // 
            // datalista
            // 
            datalista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalista.Location = new Point(12, 152);
            datalista.Name = "datalista";
            datalista.Size = new Size(456, 252);
            datalista.TabIndex = 10;
            // 
            // btneliminarcliente
            // 
            btneliminarcliente.Location = new Point(227, 103);
            btneliminarcliente.Name = "btneliminarcliente";
            btneliminarcliente.Size = new Size(111, 23);
            btneliminarcliente.TabIndex = 11;
            btneliminarcliente.Text = "Eliminar Cliente";
            btneliminarcliente.UseVisualStyleBackColor = true;
            btneliminarcliente.Click += btneliminarcliente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 21);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 14;
            label6.Text = "NOMBRE";
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(30, 415);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(75, 23);
            btnPedidos.TabIndex = 15;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += button1_Click;
            // 
            // btnsiguiente
            // 
            btnsiguiente.Location = new Point(282, 415);
            btnsiguiente.Name = "btnsiguiente";
            btnsiguiente.Size = new Size(101, 23);
            btnsiguiente.TabIndex = 16;
            btnsiguiente.Text = "Lista de juegos";
            btnsiguiente.UseVisualStyleBackColor = true;
            btnsiguiente.Click += btnsiguiente_Click;
            // 
            // TITULO
            // 
            TITULO.AutoSize = true;
            TITULO.Location = new Point(581, 103);
            TITULO.Name = "TITULO";
            TITULO.Size = new Size(0, 15);
            TITULO.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(527, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 386);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(pictureBox1);
            Controls.Add(TITULO);
            Controls.Add(btnsiguiente);
            Controls.Add(btnPedidos);
            Controls.Add(label6);
            Controls.Add(btneliminarcliente);
            Controls.Add(datalista);
            Controls.Add(btnguardarcliente);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(txtapellido);
            Controls.Add(label3);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "LISTA CLIENTES";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)datalista).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private Label label3;
        private TextBox txtapellido;
        private TextBox txtid;
        private Label label4;
        private TextBox txtcorreo;
        private Label label5;
        private Button btnguardarcliente;
        private DataGridView datalista;
        private Button btneliminarcliente;
        private Label label6;
        private Button btnPedidos;
        private Button btnsiguiente;
        private Label TITULO;
        private PictureBox pictureBox1;
    }
}
