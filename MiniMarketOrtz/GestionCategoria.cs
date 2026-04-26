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

        private int idSeleccionado = -1;
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
                idSeleccionado = seleccionada.idCategoria;

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

            var categoriaEncontrada = Repositorio.Categorias.FirstOrDefault(c => c.idCategoria == idSeleccionado);

            if (categoriaEncontrada != null)
            {
                categoriaEncontrada.Nombre = txtNombre.Text;
                categoriaEncontrada.Descripcion = txtDescripcion.Text;

                txtNombre.Clear();
                txtDescripcion.Clear();
                idSeleccionado = -1;
                refrescarGrid();

                MessageBox.Show("Registro actualizado.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var categoriaAEliminar = Repositorio.Categorias.FirstOrDefault(c => c.idCategoria == idSeleccionado);

            if (categoriaAEliminar != null)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar la categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    Repositorio.Categorias.Remove(categoriaAEliminar);

                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    idSeleccionado = -1;
                    refrescarGrid();

                    MessageBox.Show("Registro eliminado exitosamente.");
                }
            }
        }
    }
}


