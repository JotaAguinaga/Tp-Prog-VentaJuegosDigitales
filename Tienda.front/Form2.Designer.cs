namespace Tienda.front
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dataGridView1 = new DataGridView();
            columnaProducto = new DataGridViewTextBoxColumn();
            columnacopias = new DataGridViewTextBoxColumn();
            columnajuego = new DataGridViewTextBoxColumn();
            columnaprecio = new DataGridViewTextBoxColumn();
            txtproductonombre = new Label();
            txtf2stock = new Label();
            label3 = new Label();
            label4 = new Label();
            btnelimarproducto = new Button();
            btnagregarproducto = new Button();
            button3 = new Button();
            btnf1 = new Button();
            txtnombref2 = new TextBox();
            txtstockf2 = new TextBox();
            txtidf2 = new TextBox();
            txtpreciof2 = new TextBox();
            btnmostrarlistacompleta = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnaProducto, columnacopias, columnajuego, columnaprecio });
            dataGridView1.Location = new Point(429, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 278);
            dataGridView1.TabIndex = 0;
            // 
            // columnaProducto
            // 
            columnaProducto.HeaderText = "Producto";
            columnaProducto.Name = "columnaProducto";
            // 
            // columnacopias
            // 
            columnacopias.HeaderText = "Copias";
            columnacopias.Name = "columnacopias";
            // 
            // columnajuego
            // 
            columnajuego.HeaderText = "IdJuego";
            columnajuego.Name = "columnajuego";
            // 
            // columnaprecio
            // 
            columnaprecio.HeaderText = "$";
            columnaprecio.Name = "columnaprecio";
            // 
            // txtproductonombre
            // 
            txtproductonombre.AutoSize = true;
            txtproductonombre.Location = new Point(12, 29);
            txtproductonombre.Name = "txtproductonombre";
            txtproductonombre.Size = new Size(51, 15);
            txtproductonombre.TabIndex = 1;
            txtproductonombre.Text = "Nombre";
            txtproductonombre.Click += label1_Click;
            // 
            // txtf2stock
            // 
            txtf2stock.AutoSize = true;
            txtf2stock.Location = new Point(12, 70);
            txtf2stock.Name = "txtf2stock";
            txtf2stock.Size = new Size(36, 15);
            txtf2stock.TabIndex = 2;
            txtf2stock.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "ID JUEGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            // 
            // btnelimarproducto
            // 
            btnelimarproducto.Location = new Point(26, 211);
            btnelimarproducto.Name = "btnelimarproducto";
            btnelimarproducto.Size = new Size(75, 23);
            btnelimarproducto.TabIndex = 5;
            btnelimarproducto.Text = "Eliminar";
            btnelimarproducto.UseVisualStyleBackColor = true;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Location = new Point(289, 211);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(75, 23);
            btnagregarproducto.TabIndex = 6;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(44, 394);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Pedidos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnf1
            // 
            btnf1.Location = new Point(769, 394);
            btnf1.Name = "btnf1";
            btnf1.Size = new Size(105, 23);
            btnf1.TabIndex = 8;
            btnf1.Text = "Lista Clientes";
            btnf1.UseVisualStyleBackColor = true;
            btnf1.Click += btnf1_Click;
            // 
            // txtnombref2
            // 
            txtnombref2.Location = new Point(69, 26);
            txtnombref2.Name = "txtnombref2";
            txtnombref2.Size = new Size(292, 23);
            txtnombref2.TabIndex = 9;
            txtnombref2.Tag = "";
            // 
            // txtstockf2
            // 
            txtstockf2.Location = new Point(69, 67);
            txtstockf2.Name = "txtstockf2";
            txtstockf2.Size = new Size(292, 23);
            txtstockf2.TabIndex = 10;
            // 
            // txtidf2
            // 
            txtidf2.Location = new Point(70, 116);
            txtidf2.Name = "txtidf2";
            txtidf2.Size = new Size(292, 23);
            txtidf2.TabIndex = 11;
            // 
            // txtpreciof2
            // 
            txtpreciof2.Location = new Point(72, 158);
            txtpreciof2.Name = "txtpreciof2";
            txtpreciof2.Size = new Size(292, 23);
            txtpreciof2.TabIndex = 12;
            // 
            // btnmostrarlistacompleta
            // 
            btnmostrarlistacompleta.Location = new Point(580, 296);
            btnmostrarlistacompleta.Name = "btnmostrarlistacompleta";
            btnmostrarlistacompleta.Size = new Size(149, 23);
            btnmostrarlistacompleta.TabIndex = 13;
            btnmostrarlistacompleta.Text = "Ver todos los productos";
            btnmostrarlistacompleta.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(523, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 386);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(btnmostrarlistacompleta);
            Controls.Add(txtpreciof2);
            Controls.Add(txtidf2);
            Controls.Add(txtstockf2);
            Controls.Add(txtnombref2);
            Controls.Add(btnf1);
            Controls.Add(button3);
            Controls.Add(btnagregarproducto);
            Controls.Add(btnelimarproducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtf2stock);
            Controls.Add(txtproductonombre);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Lista Juegos";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columnaProducto;
        private DataGridViewTextBoxColumn columnacopias;
        private DataGridViewTextBoxColumn columnajuego;
        private DataGridViewTextBoxColumn columnaprecio;
        private Label txtproductonombre;
        private Label txtf2stock;
        private Label label3;
        private Label label4;
        private Button btnelimarproducto;
        private Button btnagregarproducto;
        private Button button3;
        private Button btnf1;
        private TextBox txtnombref2;
        private TextBox txtstockf2;
        private TextBox txtidf2;
        private TextBox txtpreciof2;
        private Button btnmostrarlistacompleta;
        private PictureBox pictureBox1;
    }
}