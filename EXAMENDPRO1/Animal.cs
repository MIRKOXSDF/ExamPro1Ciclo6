using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Animal 
    {
        public string nombre;
        public int tiempoCrecimiento;
        public int reproduccionActual;
        public string tipoOrdeñar;
        public int totalAlOrdeñar; 
        public int cantidadActualAlOrdeñar; 
        public int cantidadCarne; 
        public int totalOrdeñado; 

        public Animal(string nombre, string tipoOrdeñar, int tiempoCrecimiento, int totalAlOrdeñar, int cantidadActualAlOrdeñar, int cantidadCarne)
        {
            this.nombre = nombre;
            this.tipoOrdeñar = tipoOrdeñar;
            this.tiempoCrecimiento = tiempoCrecimiento;
            this.reproduccionActual = 0;
            this.totalAlOrdeñar = totalAlOrdeñar;
            this.cantidadActualAlOrdeñar = cantidadActualAlOrdeñar;
            this.cantidadCarne = cantidadCarne;
            this.totalOrdeñado = 0;
        }


        public void Ordeñar()
        {
            reproduccionActual++;
            totalOrdeñado += cantidadActualAlOrdeñar;

            Console.WriteLine($"{nombre} te dio {cantidadActualAlOrdeñar} de {tipoOrdeñar}");
            Console.WriteLine($"{nombre} ha producido {reproduccionActual} veces y necesita {tiempoCrecimiento} para ser eliminado.");
        }
        public void EliminarAnimal()
        {
            Console.WriteLine($"{nombre} te dio un total de {totalOrdeñado} de {tipoOrdeñar} durante su ciclo de vida.");
            Console.WriteLine($"Además, al eliminar a {nombre}, obtuviste {cantidadCarne} de carne.");
        }





    }
}
