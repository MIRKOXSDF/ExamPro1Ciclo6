using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class SemillaDePapa :Semilla
    {
        public int cantidadPapas;
        Inventario inventario;

        public SemillaDePapa(string nombre, int tiempoCrecimiento,Inventario inventario) : base(nombre, tiempoCrecimiento)
        {
            this.inventario = inventario;
            cantidadPapas = 4; 

        }

        public override void Cosechar()
        {
            if (crecimientoActual >= tiempoCrecimiento)
            {
                Console.WriteLine($"¡Has cosechado {cantidadPapas} papas!");
               
                inventario.AgregarProducto("papa", cantidadPapas);

                

                
                crecimientoActual = 0;
            }
            else
            {
                Console.WriteLine($"La papa aún no está listo. Faltan {tiempoCrecimiento - crecimientoActual} turnos para cosechar.");
            }
        }

        public override void Crecer()
        {
            crecimientoActual++;
            Console.WriteLine($"La semilla de papa ha sido plantado. Estado actual: {crecimientoActual}/{tiempoCrecimiento}.");

        }
    }
}
