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
        public int cantidadDeLeche;

        public Animal(string name, int cantidadDeLeche)
        {
            this.nombre = name;
            this.cantidadDeLeche = cantidadDeLeche;
        }

        public void Ordeñar()
        {
            if (cantidadDeLeche > 0)
            {
                Console.WriteLine($"Ordeñaste a {nombre} y obtuviste {cantidadDeLeche} litros de leche.");

            }
            else
            {
                Console.WriteLine($"{nombre} no tiene leche disponible.");

            }
        }
    }
}
