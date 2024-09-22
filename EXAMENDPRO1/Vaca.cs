using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Vaca : Animal
    {
        public int cantidadDeCarneRes=1;
        Inventario inventario;
      
        public Vaca(string name,string tipoOrdeñar) : base(name,tipoOrdeñar,5,0,1,"Carne de Res",0)
        {
        }
        public override void RecibirCarne()
        {
            Console.WriteLine($"{nombre} te dio {cantidadDeCarneRes} de carne de Res.");
            inventario.AgregarCarne("Carne de Res", cantidadDeCarneRes);
        }
    }
}
