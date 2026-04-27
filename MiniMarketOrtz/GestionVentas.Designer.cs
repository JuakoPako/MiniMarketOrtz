namespace MiniMarketOrtz
{
    partial class GestionVentas
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
            btnAgregar = new Button();
            btnEditar = new Button();
            dgvCarrito = new DataGridView();
            cmbProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            lblNeto = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnVolver = new Button();
            dgvHistorial = new DataGridView();
            btnRegistrarVenta = new Button();
            btnEliminarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DeepSkyBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(25, 278);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 26);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DeepSkyBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(163, 278);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 26);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(12, 70);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(285, 196);
            dgvCarrito.TabIndex = 3;
            dgvCarrito.CellClick += dgvCarrito_CellClick;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(117, 32);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 4;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(436, 32);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 5;
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(41, 203);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(0, 15);
            lblNeto.TabIndex = 6;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(41, 233);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(0, 15);
            lblIVA.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(41, 260);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 8;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(41, 35);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(66, 17);
            lblProducto.TabIndex = 9;
            lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Century Gothic", 9F);
            lblCantidad.Location = new Point(348, 35);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(67, 17);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DeepSkyBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(25, 307);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 26);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DeepSkyBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(163, 307);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Century Gothic", 9F);
            btnVolver.Location = new Point(12, 406);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(325, 70);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(287, 196);
            dgvHistorial.TabIndex = 14;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.DeepSkyBlue;
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.Font = new Font("Century Gothic", 9F);
            btnRegistrarVenta.ForeColor = Color.White;
            btnRegistrarVenta.Location = new Point(366, 280);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(109, 26);
            btnRegistrarVenta.TabIndex = 15;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.BackColor = Color.DeepSkyBlue;
            btnEliminarVenta.FlatStyle = FlatStyle.Flat;
            btnEliminarVenta.Font = new Font("Century Gothic", 9F);
            btnEliminarVenta.ForeColor = Color.White;
            btnEliminarVenta.Location = new Point(481, 280);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(100, 26);
            btnEliminarVenta.TabIndex = 16;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = false;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // GestionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(624, 441);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(dgvHistorial);
            Controls.Add(btnVolver);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblTotal);
            Controls.Add(lblIVA);
            Controls.Add(lblNeto);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(dgvCarrito);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "GestionVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionVentas";
            Load += GestionVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnVender;
        private Button btnEditar;
        private DataGridView dgvCarrito;
        private ComboBox cmbProducto;
        private NumericUpDown nudCantidad;
        private Label lblNeto;
        private Label lblIVA;
        private Label lblTotal;
        private Label lblProducto;
        private Label lblCantidad;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnVolver;
        private DataGridView dgvHistorial;
        private Button btnRegistrarVenta;
        private Button btnEliminarVenta;
    }
}