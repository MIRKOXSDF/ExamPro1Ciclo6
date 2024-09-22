using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class SemillaPlatano : Semilla
    {
        public int cantidadPlatano;

        public SemillaPlatano(string nombre, int tiempoCrecimiento) : base(nombre, tiempoCrecimiento)
        {
            cantidadPlatano = 4;
        }

        public override void Cosechar()
        {
            if (crecimientoActual >= tiempoCrecimiento)
            {
                Console.WriteLine($"¡Has cosechado {cantidadPlatano} platanos!");
                crecimientoActual = 0; 
            }
            else
            {
                Console.WriteLine($"El plátano aún no está listo. Faltan {tiempoCrecimiento - crecimientoActual} turnos para cosechar.");
            }
        }

        public override void Crecer()
        {
            crecimientoActual++;
            Console.WriteLine($"La semilla de plátano ha sido plantado. Estado actual: {crecimientoActual}/{tiempoCrecimiento}.");
            
        }
    }
}
