using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class SemillaManzana : Semilla
    {
        public string tipoDeFruta;
        public int frutasDisponibles;
        public SemillaManzana(string nombre, int tiempoDeCrecimiento) : base(nombre, tiempoDeCrecimiento)
        {
        }

        public override void Plantar(bool plantastes)
        {
            if (plantastes)
            {
                Console.WriteLine($"Has plantado una semilla.");

            }
            else
            {
                Console.WriteLine($"No se plantó nada");

            }
        }

        public override void RecolectarFruta()
        {
            if (frutasDisponibles > 0)
            {
                Console.WriteLine($"Recolectaste {frutasDisponibles} {tipoDeFruta}(s).");
            }
            else
            {
                Console.WriteLine($"No hay más {tipoDeFruta}s disponibles para recolectar.");
            }
        }
    }
}
