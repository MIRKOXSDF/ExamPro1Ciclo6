using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    abstract class Semilla
    {
        public string nombre;
        public int tiempoCrecimiento;
        public int crecimientoActual;

        public Semilla(string nombre, int tiempoCrecimiento)
        {
            this.nombre = nombre;
            this.tiempoCrecimiento = tiempoCrecimiento;
            this.crecimientoActual = 0;
        }

        public abstract void Cosechar();



        public abstract void Crecer();
     





    }
}
