using System.Drawing.Drawing2D;

namespace MiniMarketOrtz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.PasswordChar = '*';
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "admin" && contraseña == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso");
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show(this);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color colorArriba = Color.FromArgb(245, 247, 250);
            Color colorAbajo = Color.FromArgb(214, 234, 248);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, colorArriba, colorAbajo, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
