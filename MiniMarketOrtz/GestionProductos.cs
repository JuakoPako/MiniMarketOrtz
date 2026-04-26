using MiniMarketOrtz.Modelos;
using MiniMarketOrtz.Repo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace MiniMarketOrtz
{
    public partial class GestionProductos : Form
    {
        private int idSeleccionado = -1;
        private Form menuPrincipal;

        public GestionProductos(Form menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
            CargarCategorias();
            refrescarGrid();
            //diseno
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
        }

        private void CargarCategorias()
        {
            cmbCategorias.DataSource = null;
            cmbCategorias.DataSource = Repositorio.Categorias;
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "idCategoria";
            cmbCategorias.SelectedIndex = -1;
        }

        private void refrescarGrid()
        {

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Repositorio.Productos;

            dgvProductos.Columns["IdProducto"].DisplayIndex = 0;
            dgvProductos.Columns["Codigo"].DisplayIndex = 1;
            dgvProductos.Columns["Nombre"].DisplayIndex = 2;
            dgvProductos.Columns["Precio"].DisplayIndex = 3;
            dgvProductos.Columns["Stock"].DisplayIndex = 4;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "" || cmbCategorias.SelectedValue == null)
            {
                MessageBox.Show("Faltan datos obligatorios.");
                return;
            }

            // generar id
            int idAuto = Repositorio.Productos.Count > 0 ?
                         Repositorio.Productos.Max(p => p.IdProducto) + 1 : 1;

            // codigo automatico
            string codigoP00 = "P" + idAuto.ToString("D3");


            Producto nuevo = new Producto(
                idAuto,
                codigoP00,
                txtNombre.Text,
                decimal.Parse(txtPrecio.Text),
                int.Parse(txtStock.Text),
                (int)cmbCategorias.SelectedValue
            );

            Repositorio.Productos.Add(nuevo);
            refrescarGrid();


            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            Producto seleccionado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

            if (seleccionado != null)
            {
                idSeleccionado = seleccionado.IdProducto;
                txtNombre.Text = seleccionado.Nombre;
                txtPrecio.Text = seleccionado.Precio.ToString();
                txtStock.Text = seleccionado.Stock.ToString();
                cmbCategorias.SelectedValue = seleccionado.IdCategoria;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (this.menuPrincipal != null)
            {
                this.menuPrincipal.Show();
            }
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla primero.");
                return;
            }

            
            var p = Repositorio.Productos.FirstOrDefault(x => x.IdProducto == idSeleccionado);

            if (p != null)
            {
                try
                {
                    
                    p.Nombre = txtNombre.Text;
                    p.Precio = decimal.Parse(txtPrecio.Text);
                    p.Stock = int.Parse(txtStock.Text);

                    if (cmbCategorias.SelectedValue != null)
                    {
                        p.IdCategoria = (int)cmbCategorias.SelectedValue;
                    }

                    
                    refrescarGrid();
                    idSeleccionado = -1;

                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();
                    cmbCategorias.SelectedIndex = -1;

                    MessageBox.Show("Producto actualizado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: Asegúrate de que el precio y stock sean números válidos.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un producto de la tabla para eliminarlo.");
                return;
            }

            var p = Repositorio.Productos.FirstOrDefault(x => x.IdProducto == idSeleccionado);

            if (p != null)
            {
                
                DialogResult respuesta = MessageBox.Show($"¿Estás seguro que deseas eliminar {p.Nombre}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    Repositorio.Productos.Remove(p);
                    refrescarGrid();

                    
                    idSeleccionado = -1;
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();
                    cmbCategorias.SelectedIndex = -1;

                    MessageBox.Show("Producto eliminado exitosamente.");
                }
            }
        }
    }
}