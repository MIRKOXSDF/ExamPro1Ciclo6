using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Gallina : Animal
    {
     
        public Gallina(string name,Inventario inventario) : base(name, "huevo",3,0,1,1,inventario)
        {
        }

      
    }
}
