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
        Inventario inventario;
        public Gallina(string name, string tipoOrdeñar) : base(name, tipoOrdeñar,3,0,1,"Carne de gallina",0)
        {
        }

        public override void RecibirCarne()
        {
            Console.WriteLine($"{nombre} te dio {cantidadDeCarneGallina} de carne de gallina");
            inventario.AgregarCarne("Carne de gallina", cantidadDeCarneGallina);

        }
    }
}
