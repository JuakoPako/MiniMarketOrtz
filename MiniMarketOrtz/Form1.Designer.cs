namespace MiniMarketOrtz
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
            lblTitulo = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("TechnicBold", 13F, FontStyle.Bold, GraphicsUnit.Point, 2);
            lblTitulo.Location = new Point(219, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MINIMARKET ORTZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TechnicBold", 11F);
            label2.Location = new Point(255, 67);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 2;
            label2.Text = "Iniciar Sesion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TechnicBold", 9F);
            label1.Location = new Point(280, 130);
            label1.Name = "label1";
            label1.Size = new Size(48, 13);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TechnicBold", 9F);
            label3.Location = new Point(269, 265);
            label3.Name = "label3";
            label3.Size = new Size(70, 13);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            label3.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(218, 167);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(179, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(219, 293);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(178, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("TechnicBold", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            button1.Location = new Point(269, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(624, 441);
            Controls.Add(button1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button button1;
    }
}
