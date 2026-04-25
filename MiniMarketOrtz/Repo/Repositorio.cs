using MiniMarketOrtz.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarketOrtz.Repo
{
    public static class Repositorio
    {
        public static List<Categoria> Categorias = new List<Categoria>();
        public static List<Producto> Productos = new List<Producto>();
        public static List<Venta> Ventas = new List<Venta>();
        public static List<DetalleVenta> DetallesVentas = new List<DetalleVenta>();

        public static decimal CalcularSoloIVA (decimal montoTotal)
        {
            return montoTotal - (montoTotal / 1.19m);
        }

        public static decimal CalcularNeto(decimal montoTotal)
        {
            return montoTotal / 1.19m;
        }

        public static decimal CalcularTotalConIVA(decimal montoNeto)
        {
            return montoNeto * 1.19m;
        }
    }
}
