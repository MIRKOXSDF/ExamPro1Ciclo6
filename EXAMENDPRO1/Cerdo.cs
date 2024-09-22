using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Cerdo : Animal
    {
       
        public Cerdo(string name, string tipoOrdeñar,Inventario inventario) : base(name, "Hot Dog",4,0,inventario,0,2)
        {
        }
      
       
    }
}
