using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Animal : IAnimal
    {
        public string nombre;
        public int tiempoCrecimiento;
        public int reproduccionActual;
        public string tipoDeCantidadEmbutido;
        public string tipoOrdeñar;
        public int cantidadOrdeñar;
        public int cantidadDeCarne;
        public int cantidad=0;
        Inventario inventario;
        public Animal(string name,string tipoOrdeñar,int tiempoCrecimiento,int reproduccionActual,int cantidadOrdeñar, string tipoDeCantidadEmbutido,int cantidadDeCarne)
        {
            this.nombre = name;
            this.tipoOrdeñar = tipoOrdeñar;
            this.tiempoCrecimiento = tiempoCrecimiento;
            this.reproduccionActual = reproduccionActual;
            this.cantidadOrdeñar = cantidadOrdeñar;
            this.tipoDeCantidadEmbutido = tipoDeCantidadEmbutido;
            this.cantidadDeCarne = cantidadDeCarne;
          
        }
        public void Crecer()
        {
            reproduccionActual++;
            if ( reproduccionActual>= tiempoCrecimiento)
            {
                Console.WriteLine($"{nombre} ha crecido y ahora es adulto.");
            }
            else
            {
                Console.WriteLine($"{nombre} tiene {reproduccionActual} y necesita {tiempoCrecimiento} para ser eliminada");
                Ordeñar();
            }
        }


        public void Ordeñar()
        {
            Console.WriteLine($"Ordeñaste a {nombre} y obtuviste {cantidadOrdeñar} de {tipoOrdeñar}.");
            inventario.AgregarProductoOrdeñado(tipoOrdeñar, cantidadOrdeñar);


        }
        public virtual void RecibirCarne()
        {
        }


    }
}
