using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Animal : IAnimal
    {
        public string nombre;
        public int cantidad;

        public Animal(string name, int cantidad)
        {
            this.nombre = name;
            this.cantidad = cantidad;
        }

        public void Ordeñar()
        {
            if (cantidad > 0)
            {
                Console.WriteLine($"Ordeñaste a {nombre} y obtuviste {cantidad} litros de leche.");

            }
            else
            {
                Console.WriteLine($"{nombre} no tiene leche disponible.");

            }
        }
    }
}
