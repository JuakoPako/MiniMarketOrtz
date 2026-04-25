using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            GestionCategoria gestionCategoria = new GestionCategoria();
            gestionCategoria.Show(this);
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            GestionVentas gestionVentas = new GestionVentas();
            gestionVentas.Show(this);
            this.Hide();
        }
    }
}
