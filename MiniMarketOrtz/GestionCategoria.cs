using MiniMarketOrtz.Modelos;
using MiniMarketOrtz.Repo;
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
    public partial class GestionCategoria : Form
    {

        int idProgresivo = 1;
        public GestionCategoria()
        {
            InitializeComponent();

        }


        private void refrescarGrid()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = Repositorio.Categorias;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Faltan datos obligatorios.");
                return;
            }

            int idAuto = Repositorio.Categorias.Count > 0 ?
                         Repositorio.Categorias.Max(c => c.idCategoria) + 1 : 1;

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            Categoria nueva = new Categoria(idAuto, nombre, descripcion);
            Repositorio.Categorias.Add(nueva);

            txtNombre.Clear();
            txtDescripcion.Clear();
            refrescarGrid();

        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Categoria seleccionada = (Categoria)dgvCategorias.Rows[e.RowIndex].DataBoundItem;

                txtNombre.Text = seleccionada.Nombre;
                txtDescripcion.Text = seleccionada.Descripcion;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("No se pueden guardar campos vacíos.");
                return;
            }

            int idABuscar = int.Parse(txtId.Text);
            var categoriaEncontrada = Repositorio.Categorias.FirstOrDefault(c => c.idCategoria == idABuscar);
        }
    }
}
