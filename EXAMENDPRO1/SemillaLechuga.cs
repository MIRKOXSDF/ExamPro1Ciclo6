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
        Inventario inventario;
        public SemillaLechuga(string nombre, int tiempoCrecimiento,Inventario inventario) : base(nombre, tiempoCrecimiento)
        {
            this.inventario = inventario;
            cantidadLechugas = 3; 

        }

        public override void Cosechar()
        {
            if (crecimientoActual >= tiempoCrecimiento)
            {
                Console.WriteLine($"¡Has cosechado {cantidadLechugas} lechugas!");
                
                inventario.AgregarProducto("lechuga", cantidadLechugas);

                

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
