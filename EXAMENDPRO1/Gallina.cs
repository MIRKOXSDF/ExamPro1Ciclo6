using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Gallina : Animal
    {
        public int cantidadDeCarneGallina=1;
        public Gallina(string name, string tipoOrdeñar,Inventario inventario) : base(name, "Huevo",3,0,inventario,0,1)
        {
        }

      
    }
}
