namespace MiniMarketOrtz
{
    partial class MenuPrincipal
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
            btnProductos = new Button();
            btnCategorias = new Button();
            btnVentas = new Button();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.DeepSkyBlue;
            btnProductos.FlatStyle = FlatStyle.Popup;
            btnProductos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(207, 114);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(211, 35);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.DeepSkyBlue;
            btnCategorias.FlatStyle = FlatStyle.Popup;
            btnCategorias.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(207, 200);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(211, 35);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.DeepSkyBlue;
            btnVentas.FlatStyle = FlatStyle.Popup;
            btnVentas.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(207, 291);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(211, 35);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(624, 441);
            Controls.Add(btnVentas);
            Controls.Add(btnCategorias);
            Controls.Add(btnProductos);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnCategorias;
        private Button btnVentas;
    }
}