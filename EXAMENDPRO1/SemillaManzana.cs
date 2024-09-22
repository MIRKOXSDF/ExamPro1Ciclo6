using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class SemillaManzana : Semilla
    {
        public int cantidadManzanas;

        public SemillaManzana(string nombre, int tiempoCrecimiento) : base(nombre, tiempoCrecimiento)
        {
            cantidadManzanas = 5;
        }

        public override void Cosechar()
        {
            if (crecimientoActual >= tiempoCrecimiento)
            {
                Console.WriteLine($"¡Has cosechado {cantidadManzanas} manzanas!");
                crecimientoActual = 0; 
            }
            else
            {
                Console.WriteLine($"La manzana aún no está lista. Faltan {tiempoCrecimiento - crecimientoActual} turnos para cosechar.");
            }
        }

        public override void Crecer()
        {
            crecimientoActual++;
            Console.WriteLine($"La semilla de manzana ha sido0 plantado. Estado actual: {crecimientoActual}/{tiempoCrecimiento}.");
        }
    }
}
