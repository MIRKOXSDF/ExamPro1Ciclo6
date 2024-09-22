using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Inventario
    {
        public int totalCarneGallina = 0;
        public int totalCarneCerdo = 0;
        public int totalCarneVaca = 0;

        public int totalLecheVaca = 0;  
        public int totalHuevosGallina = 0; 

        public void AgregarCarne(string tipoCarne, int cantidad)
        {
            switch (tipoCarne)
            {
                case "Carne de gallina":
                    totalCarneGallina += cantidad;
                    break;
                case "Carne de cerdo":
                    totalCarneCerdo += cantidad;
                    break;
                case "Carne de Res":
                    totalCarneVaca += cantidad;
                    break;
                default:
                    Console.WriteLine("Tipo de carne no reconocida.");
                    break;
            }
        }

        public void AgregarProductoOrdeñado(string tipoProducto, int cantidad)
        {
            switch (tipoProducto)
            {
                case "Leche":
                    totalLecheVaca += cantidad;
                    break;
                case "Huevos":
                    totalHuevosGallina += cantidad;
                    break;
                default:
                    Console.WriteLine("Tipo de producto no reconocido.");
                    break;
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario:");
            Console.WriteLine($"Carne de Gallina: {totalCarneGallina}");
            Console.WriteLine($"Carne de Cerdo: {totalCarneCerdo}");
            Console.WriteLine($"Carne de Res: {totalCarneVaca}");
            Console.WriteLine($"Leche de Vaca: {totalLecheVaca}");
            Console.WriteLine($"Huevos de Gallina: {totalHuevosGallina}");
        }
    }
}

