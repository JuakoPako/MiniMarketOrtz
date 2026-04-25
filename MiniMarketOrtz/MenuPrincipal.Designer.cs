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
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Location = new Point(83, 97);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(111, 35);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Location = new Point(83, 183);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(111, 35);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Location = new Point(83, 274);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(111, 35);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(btnVentas);
            Controls.Add(btnCategorias);
            Controls.Add(btnProductos);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnCategorias;
        private Button btnVentas;
    }
}