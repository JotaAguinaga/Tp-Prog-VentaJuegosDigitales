namespace Tienda.front
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            btnsiguiente = new Button();
            btnPedidos = new Button();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 386);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnsiguiente
            // 
            btnsiguiente.Location = new Point(76, 415);
            btnsiguiente.Name = "btnsiguiente";
            btnsiguiente.Size = new Size(101, 23);
            btnsiguiente.TabIndex = 21;
            btnsiguiente.Text = "Lista de juegos";
            btnsiguiente.UseVisualStyleBackColor = true;
            btnsiguiente.Click += btnsiguiente_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(630, 415);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(75, 23);
            btnPedidos.TabIndex = 22;
            btnPedidos.Text = "Clientes";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(355, 184);
            listBox1.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(395, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(352, 23);
            textBox3.TabIndex = 26;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(385, 35);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 28;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(512, 178);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 29;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 202);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(355, 184);
            listBox2.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 121);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 31;
            label1.Text = "Ingresar Correo";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(listBox1);
            Controls.Add(btnPedidos);
            Controls.Add(btnsiguiente);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnsiguiente;
        private Button btnPedidos;
        private ListBox listBox1;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private ListBox listBox2;
        private Label label1;
    }
}