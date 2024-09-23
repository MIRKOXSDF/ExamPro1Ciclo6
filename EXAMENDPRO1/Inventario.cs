using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Inventario
    {
        public int cantidadLechuga { get; set; }
        public int cantidadPapa { get; set; }
        public int cantidadPlatano { get; set; }
        public int cantidadManzana { get; set; }
        public int cantidadLeche { get; set; }
        public int cantidadHuevo { get; set; }

        public int cantidadCarneCerdo { get; set; }
        public int cantidadGallina { get; set; }
        public int cantidadVaca { get; set; }

        public Inventario()
        {
            cantidadLechuga = 0;
            cantidadPapa = 0;
            cantidadPlatano = 0;
            cantidadManzana = 0;
            cantidadLeche = 0;
            cantidadCarneCerdo = 0;
            cantidadGallina = 0;
            cantidadVaca = 0;
        }

        public void AgregarProducto(string producto, int cantidad)
        {
            switch (producto.ToLower())
            {
                case "lechuga":
                    cantidadLechuga += cantidad;
                    break;
                case "papa":
                    cantidadPapa += cantidad;
                    break;
                case "platano":
                    cantidadPlatano += cantidad;
                    break;
                case "manzana":
                    cantidadManzana += cantidad;
                    break;
                case "leche":
                    cantidadLeche += cantidad;
                    break;
                case "hot Dog":
                    cantidadCarneCerdo += cantidad;
                    break;
                case "huevo":
                    cantidadHuevo += cantidad;
                    break;

                default:
                    Console.WriteLine("Producto no reconocido.");
                    break;
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario:");
            Console.WriteLine($"Lechugas: {cantidadLechuga}");
            Console.WriteLine($"Papas: {cantidadPapa}");
            Console.WriteLine($"Plátanos: {cantidadPlatano}");
            Console.WriteLine($"Manzanas: {cantidadManzana}");
            Console.WriteLine($"Leche: {cantidadLeche}");
            Console.WriteLine($"Carne de cerdo: {cantidadCarneCerdo}");
            Console.WriteLine($"Gallinas: {cantidadHuevo}");
        }
    }
}
