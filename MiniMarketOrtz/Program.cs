using MiniMarketOrtz.Modelos;
using MiniMarketOrtz.Repo;

namespace MiniMarketOrtz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // CATEGORÍAS
            Repositorio.Categorias.Add(
                new Categoria(1, "Abarrotes", "Productos básicos")
            );

            Repositorio.Categorias.Add(
                new Categoria(2, "Bebidas", "Bebidas frías y jugos")
            );

            Repositorio.Categorias.Add(
                new Categoria(3, "Snacks", "Galletas y colaciones")
            );

            // PRODUCTOS
            Repositorio.Productos.Add(
                new Producto(1, "P001", "Arroz", 1500, 20, 1)
            );

            Repositorio.Productos.Add(
                new Producto(2, "P002", "Fideos", 1200, 25, 1)
            );

            Repositorio.Productos.Add(
                new Producto(3, "P003", "Aceite", 3500, 10, 1)
            );

            Repositorio.Productos.Add(
                new Producto(4, "P004", "Azúcar", 1800, 18, 1)
            );

            Repositorio.Productos.Add(
                new Producto(5, "P005", "Coca Cola 1.5L", 2200, 15, 2)
            );

            Repositorio.Productos.Add(
                new Producto(6, "P006", "Sprite 1.5L", 2200, 12, 2)
            );

            Repositorio.Productos.Add(
                new Producto(7, "P007", "Jugo Watts", 1700, 20, 2)
            );

            Repositorio.Productos.Add(
                new Producto(8, "P008", "Galletas", 1300, 22, 3)
            );

            Repositorio.Productos.Add(
                new Producto(9, "P009", "Papas Fritas", 1600, 17, 3)
            );

            Repositorio.Productos.Add(
                new Producto(10, "P010", "Chocolate", 1900, 14, 3)
            );

            Application.Run(new Form1());
        }
    }
}