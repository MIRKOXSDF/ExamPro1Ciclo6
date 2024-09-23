using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class SemillaManzana : Semilla
    {
        private Inventario inventario;
        public int cantidadManzana;

        public SemillaManzana(string nombre, int tiempoCrecimiento,Inventario inventario) : base(nombre, tiempoCrecimiento)
        {
            this.inventario = inventario;
            cantidadManzana = 4;
        }

        public override void Cosechar()
        {
            if (crecimientoActual >= tiempoCrecimiento)
            {
                Console.WriteLine($"¡Has cosechado {cantidadManzana} manzanas!");
                inventario.AgregarProducto("manzana", cantidadManzana); 
            }
            else
            {
                Console.WriteLine($"La manzana aún no está listo. Faltan {tiempoCrecimiento - crecimientoActual} turnos para cosechar.");
            }
        }

        public override void Crecer()
        {
            crecimientoActual++;
            Console.WriteLine($"La semilla de manzana ha sido plantada. Estado actual: {crecimientoActual}/{tiempoCrecimiento}.");
        }
    }
}
