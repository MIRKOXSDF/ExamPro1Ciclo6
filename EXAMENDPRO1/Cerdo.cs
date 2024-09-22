using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Cerdo : Animal
    {
        public int cantidadDeCarneCerdo=1;
        Inventario inventario;
       
        public Cerdo(string name, string tipoOrdeñar) : base(name, tipoOrdeñar,4,0,1,"Carne de cerdo",0)
        {
        }
        public override void RecibirCarne()
        {
            Console.WriteLine($"{nombre} te dio {cantidadDeCarneCerdo} de carne de cerdo.");
            inventario.AgregarCarne("Carne de cerdo", cantidadDeCarneCerdo);
        }
    }
}
