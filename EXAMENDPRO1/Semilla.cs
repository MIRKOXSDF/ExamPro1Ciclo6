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
        public int tiempoDeCrecimiento;
        protected Semilla(string nombre, int tiempoDeCrecimiento)
        {
            this.nombre = nombre;
            this.tiempoDeCrecimiento = tiempoDeCrecimiento;
        }
        public abstract void Plantar(bool plantastes);

        public abstract void RecolectarFruta();





    }
}
