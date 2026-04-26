namespace MiniMarketOrtz
{
    partial class GestionCategoria
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
            dgvDetalle = new DataGridView();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(297, 12);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.Size = new Size(300, 300);
            dgvDetalle.TabIndex = 0;
            dgvDetalle.CellClick += dgvCategorias_CellClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(41, 142);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(178, 122);
            txtDescripcion.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(41, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 17);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(41, 122);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(79, 17);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(115, 370);
            button1.Name = "button1";
            button1.Size = new Size(104, 34);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(405, 370);
            button2.Name = "button2";
            button2.Size = new Size(104, 34);
            button2.TabIndex = 5;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(260, 370);
            button3.Name = "button3";
            button3.Size = new Size(104, 34);
            button3.TabIndex = 5;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // GestionCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(624, 441);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(dgvDetalle);
            Name = "GestionCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionCategoria";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalle;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private Label lblDescripcion;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}