namespace MiniMarketOrtz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.PasswordChar = '*';
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
    }
}
