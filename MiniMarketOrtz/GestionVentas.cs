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
            CalcularTotal();
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
            dgvVental.Columns.Clear();

            dgvVental.Columns.Add("IdDetalle", "Id");
            dgvVental.Columns.Add("IdVenta", "IdVenta");
            dgvVental.Columns.Add("Producto", "Producto");
            dgvVental.Columns.Add("Cantidad", "Cantidad");
            dgvVental.Columns.Add("Precio", "Precio");
            dgvVental.Columns.Add("Total", "Total");
            dgvVental.Columns.Add("Fecha", "Fecha");
        }

        private void CargarTabla()
        {
            dgvVental.Rows.Clear();
            foreach (var detalle in Repositorio.DetallesVentas)
            {
                Producto p = Repositorio.Productos
                    .First(x => x.IdProducto == detalle.IdProducto);

                Venta v = Repositorio.Ventas
                    .First(x => x.IdVenta == detalle.IdVenta);
                
                dgvVental .Rows.Add(
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
            dgvVenta.ClearStelectedRows();
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

            carrito.Add(new DetalleVenta
            {
                IdProducto = p.IdProducto,
                Cantidad = cantidad,
                PrecioUnitario = p.Precio
            });

            decimal subTotal = cantidad * p.Precio;

            dgvVental.Rows.Add(p.Nombre,
                cantidad,
                p.Precio, subTotal
                );

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = carrito.Sum(x => x.Cantidad * x.PrecioUnitario);

            decimal neto = Repositorio.CalcularNeto(total);
            decimal iva = Repositorio.CalcularSoloIVA(total);

            lblNeto.Text = "Neto: $" + neto.ToString("0");
            lblIVA.Text = "IVA: $" + iva.ToString("0");
            lblTotal.Text = "Total: $" + total.ToString("0");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("Agregue productos al carrito antes de vender.");
                return;
            }
            decimal total = carrito.Sum(x => x.Cantidad * x.PrecioUnitario);

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

                Producto p = Repositorio.Productos.First(x => x.IdProducto == item.IdProducto);
                p.Stock -= item.Cantidad;
            }

            MessageBox.Show("Venta realizada con éxito.");

            carrito.Clear();
            dgvVental.Rows.Clear();
            CargarProductos();
            CalcularTotal();

        }
    }
}
