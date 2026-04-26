using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarketOrtz
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;

            
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            GestionCategoria gestionCategoria = new GestionCategoria(this);
            gestionCategoria.Show(this);
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            GestionVentas gestionVentas = new GestionVentas(this);
            gestionVentas.Show(this);
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            GestionProductos gestionProductos = new GestionProductos(this);
            gestionProductos.Show(this);
            this.Hide();
        }





        //diseno de ventana y programa

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
