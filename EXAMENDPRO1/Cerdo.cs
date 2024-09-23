using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Cerdo : Animal
    {
       
        public Cerdo(string name,Inventario inventario) : base(name, "hot Dog",4,0,3,2,inventario,"lechon")
        {
        }
      
       
    }
}
