using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class SemillaLechuga : Semilla
    {
        public int cantidadLechugas;

        public SemillaLechuga(string nombre, int tiempoCrecimiento) : base(nombre, tiempoCrecimiento)
        {
            cantidadLechugas = 3; 

        }

        public override void Cosechar()
        {
            if (crecimientoActual >= tiempoCrecimiento)
            {
                Console.WriteLine($"¡Has cosechado {cantidadLechugas} lechugas!");
                crecimientoActual = 0;
            }
            else
            {
                Console.WriteLine($"La lechuga aún no está listo. Faltan {tiempoCrecimiento - crecimientoActual} turnos para cosechar.");
            }
        }

        public override void Crecer()
        {
            crecimientoActual++;
            Console.WriteLine($"La semilla de lechuga ha sido plantado. Estado actual: {crecimientoActual}/{tiempoCrecimiento}.");

        }
    }
}
