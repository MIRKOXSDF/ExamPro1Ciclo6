﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Vaca : Animal 
    {
       
        public Vaca(string name,Inventario inventario) : base(name,"leche",5,0,2,1,inventario,"carne de Res")
        {
        }
       
      
    }
}
