using MiniMarketOrtz.Modelos;
using MiniMarketOrtz.Repo;
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
    public partial class GestionVentas : Form
    {
        List<DetalleVenta> carrito = new List<DetalleVenta>();
        int indexEditar = -1;
        private Form menuPrincipal;
        public GestionVentas(Form menu)
        {
            InitializeComponent();
            CargarProductos();
            ConfigurarTablas();
            CargarHistorial();
            this.menuPrincipal = menu;

        }

        private void CargarProductos()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = Repositorio.Productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.SelectedIndex = -1;
        }

        private void ConfigurarTablas()
        {
            // tabla carrito
            dgvCarrito.Columns.Clear();
            dgvCarrito.Columns.Add("Producto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("Precio", "Precio");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");

            // tabla historial
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("IdVenta", "ID");
            dgvHistorial.Columns.Add("Fecha", "Fecha");
            dgvHistorial.Columns.Add("Total", "Total");

        }

        private void CargarHistorial()
        {
            dgvHistorial.Rows.Clear();
            foreach (var venta in Repositorio.Ventas)
            {
                dgvHistorial.Rows.Add(venta.IdVenta, venta.Fecha, venta.Total);
            }
        }


        private void GestionVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            Producto p = (Producto)cmbProducto.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            if (cantidad > p.Stock)
            {
                MessageBox.Show("Stock insuficiente.");
                return;
            }

            carrito.Add(new DetalleVenta
            {
                IdProducto = p.IdProducto,
                Cantidad = cantidad,
                PrecioUnitario = p.Precio
            });

            dgvCarrito.Rows.Add(
                p.Nombre,
                cantidad,
                p.Precio,
                cantidad * p.Precio
                );
        }

        private void dgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            indexEditar = e.RowIndex;

            var celdaNombre = dgvCarrito.Rows[e.RowIndex].Cells[0].Value;
            if ( celdaNombre == null )
            {
                MessageBox.Show("La fila seleccionada no contiene un producto.");
                return;
            }

            string nombreProducto = celdaNombre.ToString();
            var producto = Repositorio.Productos.FirstOrDefault(p => p.Nombre == nombreProducto);
            if (producto != null)
            {
                cmbProducto.SelectedItem = producto;
                
            }

            var celdaCantidad = dgvCarrito.Rows[e.RowIndex].Cells[1].Value;
            if ( celdaCantidad != null && int.TryParse(celdaCantidad.ToString(), out int cantidad))
            {
                nudCantidad.Value = cantidad;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indexEditar == -1)
            {
                MessageBox.Show("Seleccione una fila para editar.");
                return;
            }

            if (cmbProducto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            Producto p = (Producto)cmbProducto.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            // Actualizar lista carrito
            carrito[indexEditar].IdProducto = p.IdProducto;
            carrito[indexEditar].Cantidad = cantidad;
            carrito[indexEditar].PrecioUnitario = p.Precio;

            // Actualizar DataGridView
            dgvCarrito.Rows[indexEditar].Cells[0].Value = p.Nombre;
            dgvCarrito.Rows[indexEditar].Cells[1].Value = cantidad;
            dgvCarrito.Rows[indexEditar].Cells[2].Value = p.Precio;
            dgvCarrito.Rows[indexEditar].Cells[3].Value = cantidad * p.Precio;

            MessageBox.Show("Producto editado correctamente.");
            indexEditar = -1; // reset para evitar ediciones accidentales
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            int fila = dgvCarrito.SelectedRows[0].Index;
            carrito.RemoveAt(fila);
            dgvCarrito.Rows.RemoveAt(fila);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            dgvCarrito.Rows.Clear();
            indexEditar = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (this.menuPrincipal != null)
            {
                this.menuPrincipal.Show();
            }

            
            this.Close();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }
            decimal total = carrito.Sum(d => d.Cantidad * d.PrecioUnitario);
            Venta venta = new Venta(
                Repositorio.Ventas.Count + 1,
                DateTime.Now,
                total
                );
            Repositorio.Ventas.Add(venta);

            foreach (var item in carrito)
            {
                item.IdDetalle = Repositorio.DetallesVentas.Count + 1;
                item.IdVenta = venta.IdVenta;

                Repositorio.DetallesVentas.Add(item);

                Producto p = Repositorio.Productos.First(pr => pr.IdProducto == item.IdProducto);

                p.Stock -= item.Cantidad;
            }
            MessageBox.Show("Venta registrada exitosamente.");

            carrito.Clear();
            dgvCarrito.Rows.Clear();
            CargarHistorial();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.CurrentRow == null)
                return;

            int idVenta = Convert.ToInt32(dgvHistorial.CurrentRow.Cells[0].Value);

            var venta = Repositorio.Ventas.First(v => v.IdVenta == idVenta);

            if (venta != null)
                Repositorio.Ventas.Remove(venta);

            CargarHistorial();
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
