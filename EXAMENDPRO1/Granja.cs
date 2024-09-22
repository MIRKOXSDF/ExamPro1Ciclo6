using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Granja
    {
        List<Animal> animal;
        Granjero granjero;
        float dinero;

        public void Game()
        {
            Console.WriteLine("Coloca el nombre del granjero : ");
            string nombre = Console.ReadLine();
            bool active = true;
            while(active)
            {
                
                try
                {
                    Console.WriteLine("Coloca la cantidad de dinero : ");
                    dinero = float.Parse(Console.ReadLine());
                    if (dinero < 0)
                    {
                        Console.WriteLine("Entrada no válida.El numero debe ser positivo");
                        continue;
                    }
                    active = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");

                }
            }
          



            granjero = new Granjero(nombre, dinero);
            Console.WriteLine($"El granjero se llama {nombre} y tiene  ${dinero} de dinero");
            ComprarObjetos();

        }

        public void ComprarObjetos()
        {
            bool active = true;
            while (active)
            {
                try
                {
                    Console.WriteLine("¿Qué te gustaría comprar?");
                    Console.WriteLine("1. Semillas");
                    Console.WriteLine("2. Animales");

                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            ComprarSemilla();
                            break;
                        case 2:
                            ComprarAnimal();
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige 1 o 2 .");
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Elige un numero entero");

                }

            }

        }
        private void ComprarAnimal()
        {
            animal = new List<Animal>();
            bool active = true;
            while (active)
            {
                Console.WriteLine("Escoge tu animal :");
                Console.WriteLine("1. Vaca");
                Console.WriteLine("2. Gallina");
                Console.WriteLine("3. Cerdo");
                Console.WriteLine("4. Lista de Animales obtenidos : ");
                Console.WriteLine("5. Salir ");

                int option = int.Parse(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Compraste una vaca");
                            Animal vaca = new Vaca("Vaca", "Leche");
                            animal.Add(vaca);
                            break;
                        case 2:
                            Console.WriteLine("Compraste una gallina");
                            Animal gallina = new Gallina("Gallina", "Pollo");
                            animal.Add(gallina);

                            break;
                        case 3:
                            Console.WriteLine("Compraste un cerdo");
                            Animal cerdo = new Cerdo("Cerdo", "Hotdog");
                            animal.Add(cerdo);
                            break;
                        case 4:
                            foreach (Animal animales in animal)
                            {
                                if(animales!=null)
                                {
                                    Console.WriteLine($"{animales.nombre}");

                                }
                                else
                                {
                                    Console.WriteLine($"No hay ningun animal obtenido");

                                }
                            }
                            break;
                        case 5:
                            return;

                            
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige 1, 2 o 3.");

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Elige un numero entero");

                }

            }
           

        }
        private void ComprarSemilla()
        {
            bool active = true;
            while (active)
            {
                Console.WriteLine("Escoge tu tipo de semilla :");
                Console.WriteLine("1. Semilla de frutas");
                Console.WriteLine("2. Semilla de verduras");
                int option = int.Parse(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            TiposDeSemillaFruta();
                            break;
                        case 2:
                            TiposDeSemillaVerdura();
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige 1 o 2 .");

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Elige un numero entero");

                }

            }
        }
        private void TiposDeSemillaFruta()
        {
            bool active = true;
            while (active)
            {
                Console.WriteLine("Escoge el tipo de semilla de fruta :");
                Console.WriteLine("1. Semilla de platano");
                Console.WriteLine("2. Semilla de manzana");
                int option = int.Parse(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Compraste una semilla de platano");

                            break;
                        case 2:
                            Console.WriteLine("Compraste una semilla de manzana");

                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige 1 o 2 .");

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Elige un numero entero");

                }

            }
        }
        private void TiposDeSemillaVerdura()
        {
            bool active = true;
            while (active)
            {
                Console.WriteLine("Escoge el tipo de semilla de verdura :");
                Console.WriteLine("1. Semilla de papa");
                Console.WriteLine("2. Semilla de lechuga");
                int option = int.Parse(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Compraste una semilla de platano");

                            break;
                        case 2:
                            Console.WriteLine("Compraste una semilla de manzana");

                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige 1 o 2 .");

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Elige un numero entero");

                }

            }
        }
    }
}
