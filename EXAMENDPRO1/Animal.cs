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
        public string tipoDeCantidadEmbutido;
        public string tipoOrdeñar;
        public int totalAlOrdeñar;
        public int cantidadActualAlOrdeñar;
        Inventario inventario;
        public Animal(string name, string tipoOrdeñar, int tiempoCrecimiento, int reproduccionActual,Inventario inventario,int totalAlOrdeñar,int cantidadActualAlOrdeñar)
        {
            this.nombre = name;
            this.tipoOrdeñar = tipoOrdeñar;
            this.tiempoCrecimiento = tiempoCrecimiento;
            this.reproduccionActual = reproduccionActual;
            this.cantidadActualAlOrdeñar = cantidadActualAlOrdeñar;
            this.totalAlOrdeñar = totalAlOrdeñar;
            this.inventario = inventario;
        }
       
       
        public void Ordeñar()
        {
            reproduccionActual++;
          

            Console.WriteLine($"{nombre} te dio {cantidadActualAlOrdeñar} de {tipoOrdeñar}");
            Console.WriteLine($"{nombre} tiene {reproduccionActual} y necesita {tiempoCrecimiento} para ser eliminada");
        }





    }
}
