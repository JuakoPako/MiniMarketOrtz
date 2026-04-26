using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniMarketOrtz.Modelos;
using MiniMarketOrtz.Repo;

namespace MiniMarketOrtz
{
    public partial class GestionVentas : Form
    {
        int idEditar = 0;
        public GestionVentas()
        {
            InitializeComponent();
            CargarProductos();
            ConfigurarTabla();
            LimpiarCampos();
        }

        private void CargarProductos()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = Repositorio.Productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.SelectedIndex = -1;
        }

        private void ConfigurarTabla()
        {
            dgvVentas.Columns.Clear();

            dgvVentas.Columns.Add("IdDetalle", "Id");
            dgvVentas.Columns.Add("IdVenta", "IdVenta");
            dgvVentas.Columns.Add("Producto", "Producto");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("Precio", "Precio");
            dgvVentas.Columns.Add("Total", "Total");
            dgvVentas.Columns.Add("Fecha", "Fecha");
        }

        private void CargarTabla()
        {
            dgvVentas.Rows.Clear();
            foreach (var detalle in Repositorio.DetallesVentas)
            {
                Producto p = Repositorio.Productos
                    .First(x => x.IdProducto == detalle.IdProducto);

                Venta v = Repositorio.Ventas
                    .First(x => x.IdVenta == detalle.IdVenta);

                dgvVentas.Rows.Add(
                    detalle.IdDetalle,
                    detalle.IdVenta,
                    p.Nombre,
                    detalle.Cantidad,
                    detalle.PrecioUnitario,
                    detalle.Cantidad * detalle.PrecioUnitario,
                    v.Fecha.ToString()

                    );
            }
        }

        private void LimpiarCampos()
        {
            cmbProducto.SelectedIndex = -1;
            nudCantidad.Value = 1;
            idEditar = 0;
            dgvVentas.ClearSelection();
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

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }
            if (cantidad > p.Stock)
            {
                MessageBox.Show("No hay suficiente stock disponible.");
                return;
            }

            Venta venta = new Venta(
                Repositorio.Ventas.Count + 1,
                DateTime.Now,
                cantidad * p.Precio
                );

            Repositorio.Ventas.Add(venta);

            DetalleVenta detalle = new DetalleVenta(
                Repositorio.DetallesVentas.Count + 1,
                venta.IdVenta,
                p.IdProducto,
                cantidad,
                p.Precio
                );

            Repositorio.DetallesVentas.Add(detalle);

            p.Stock -= cantidad;

            CargarTabla();
            LimpiarCampos();

            MessageBox.Show("Venta agregada correctamente.");

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idEditar = Convert.ToInt32(
                dgvVentas.Rows[e.RowIndex].Cells[0].Value);

            string nombreProducto = dgvVentas.Rows[e.RowIndex].Cells[2].Value.ToString();

            int cantidad = Convert.ToInt32(
                dgvVentas.Rows[e.RowIndex].Cells[3].Value);

            cmbProducto.Text = nombreProducto;
            nudCantidad.Value = cantidad;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idEditar == 0)
            {
                MessageBox.Show("Seleccione una venta para editar.");
                return;
            }
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            var detalle = Repositorio.DetallesVentas
                .First(x => x.IdDetalle == idEditar);

            if (detalle == null)
                return;

            Producto productoAnterior = Repositorio.Productos
                .First(x => x.IdProducto == detalle.IdProducto);

            productoAnterior.Stock += detalle.Cantidad;

            Producto nuevoProducto = (Producto)cmbProducto.SelectedItem;
            int nuevaCantidad = (int)nudCantidad.Value;

            if (nuevaCantidad > nuevoProducto.Stock)
            {
                MessageBox.Show("Stock insuficiente");
                productoAnterior.Stock -= detalle.Cantidad;
                return;
            }

            detalle.IdProducto = nuevoProducto.IdProducto;
            detalle.Cantidad = nuevaCantidad;
            detalle.PrecioUnitario = nuevoProducto.Precio;

            nuevoProducto.Stock -= nuevaCantidad;

            Venta venta = Repositorio.Ventas
                .First(x => x.IdVenta == detalle.IdVenta);

            venta.Total = nuevaCantidad * nuevoProducto.Precio;

            CargarTabla();
            LimpiarCampos();

            MessageBox.Show("Venta editada correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEditar == 0)
            {
                MessageBox.Show("Seleccione una venta para eliminar.");
                return;
            }

            var detalle = Repositorio.DetallesVentas
                .FirstOrDefault(x => x.IdDetalle == idEditar);

            if (detalle == null)
                return;

            Producto p = Repositorio.Productos.First(x => x.IdProducto == detalle.IdProducto);

            if (p != null)
                p.Stock += detalle.Cantidad;

            Repositorio.DetallesVentas.Remove(detalle);

            var venta = Repositorio.Ventas
                .FirstOrDefault(x => x.IdVenta == detalle.IdVenta);

            if (venta != null)
                Repositorio.Ventas.Remove(venta);

            CargarTabla();
            LimpiarCampos();

            MessageBox.Show("Venta eliminada correctamente.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show(this);
            this.Hide();
        }
    }
}
