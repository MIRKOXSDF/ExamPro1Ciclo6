using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Vaca : Animal 
    {
        
        public Vaca(string name,string tipoOrdeñar,Inventario inventario) : base(name,"Leche",5,0,inventario,0,1)
        {
        }
       
      
    }
}
