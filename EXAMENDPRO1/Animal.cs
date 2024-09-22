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
        public string tipoOrdeñar;
        public Animal(string name,string tipoOrdeñar)
        {
            this.nombre = name;
            this.tipoOrdeñar = tipoOrdeñar;
          
        }

        public void Ordeñar()
        {
            if (cantidad > 0)
            {
                Console.WriteLine($"Ordeñaste a {nombre} y obtuviste {cantidad} de {tipoOrdeñar}");

            }
            else
            {
                Console.WriteLine($"{nombre} no tiene nada disponible");

            }
        }
    }
}
