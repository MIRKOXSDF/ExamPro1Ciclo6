using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDPRO1
{
    class Granja
    {
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
            List<Semilla> semilla;

            Granjero granjero;
            float dinero;

            public void Game()
            {
                animal = new List<Animal>();
                semilla = new List<Semilla>();

                Console.WriteLine("Coloca el nombre del granjero : ");
                string nombre = Console.ReadLine();
                bool active = true;
                while (active)
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
                        Console.WriteLine("¿Qué te gustaría hacer?");
                        Console.WriteLine("1. Comprar semillas");
                        Console.WriteLine("2. Comprar Animales");
                        Console.WriteLine("3. Iniciar a trabajar");

                        int option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                ComprarSemilla();
                                break;
                            case 2:
                                ComprarAnimal();
                                break;
                            case 3:
                                if (semilla.Count == 0 && animal.Count == 0)
                                {
                                    Console.WriteLine("No hay ningúna semilla y animal comprada.");

                                }
                                IniciarTrabajar();
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
            private void IniciarTrabajar()
            {
                Console.WriteLine("¿Qué te gustaría hacer?");
                Console.WriteLine("1. Sembrar semilla");
                Console.WriteLine("2. Criar animales");
                Console.WriteLine("3. Salir");

                bool active = true;
                int option = int.Parse(Console.ReadLine());
                while (active)
                {
                    switch (option)
                    {
                        case 1:
                            SembrarSemilla();
                            break;
                        case 2:
                            CriarAnimales();
                            break;
                        case 3:
                            return;
                    }
                }
            }
            private void SembrarSemilla()
            {

            }
            private void CriarAnimales()
            {
                int opcion = 0;
                if (animal.Count == 0)
                {
                    Console.WriteLine("No tienes animales que criar.");
                    return;
                }

                Console.WriteLine("Selecciona un animal para criar:");
                for (int i = 0; i < animal.Count; i++)
                {
                    Animal a = animal[i];
                    Console.WriteLine($"{i + 1}. {a.nombre} ");
                }
                try
                {
                    opcion = int.Parse(Console.ReadLine()) - 1;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Elige un numero entero");

                }

                Animal seleccion = animal[opcion];
                seleccion.Crecer();
                if (seleccion.reproduccionActual >= seleccion.tiempoCrecimiento)
                {
                    Console.WriteLine($"{seleccion.nombre} ha completado su ciclo y ha sido eliminado.");
                    seleccion.RecibirCarne();
                    animal.RemoveAt(opcion);
                }


            }
            private void ComprarAnimal()
            {
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
                                Console.WriteLine($"Gastastes $30 y ahora te queda ${dinero -= 30} de dinero");

                                Animal vaca = new Vaca("Vaca", "Leche");
                                animal.Add(vaca);
                                break;
                            case 2:
                                Console.WriteLine("Compraste una gallina");
                                Console.WriteLine($"Gastastes $10 y ahora te queda ${dinero -= 10} de dinero");

                                Animal gallina = new Gallina("Gallina", "Huevo");
                                animal.Add(gallina);

                                break;
                            case 3:
                                Console.WriteLine("Compraste un cerdo");
                                Console.WriteLine($"Gastastes $20 y ahora te queda ${dinero -= 20} de dinero");

                                Animal cerdo = new Cerdo("Cerdo", "Hotdog");
                                animal.Add(cerdo);
                                break;
                            case 4:
                                if (animal.Count == 0)
                                {
                                    Console.WriteLine("No hay ningún animal comprado.");
                                }
                                int i = 0;
                                foreach (Animal animales in animal)
                                {
                                    if (animales != null)
                                    {
                                        i++;
                                        Console.WriteLine($"{i}.Animal {animales.nombre}");

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
                    Console.WriteLine("3. Lista de Animales obtenidos : ");
                    Console.WriteLine("4. Salir ");
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
                            case 3:
                                if (semilla.Count == 0)
                                {
                                    Console.WriteLine("No hay ningúna semilla comprada.");
                                }
                                int i = 0;
                                foreach (Semilla semillas in semilla)
                                {
                                    if (semillas != null)
                                    {
                                        i++;
                                        Console.WriteLine($"{i}. {semillas.nombre}");

                                    }

                                }
                                break;
                            case 4:
                                return;

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
                    Console.WriteLine("3. Salir ");

                    int option = int.Parse(Console.ReadLine());
                    try
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Compraste una semilla de platano");
                                Console.WriteLine($"Gastastes $10 y ahora te queda ${dinero -= 10} de dinero");

                                Semilla platano = new SemillaPlatano("Semilla de platano", 4);
                                semilla.Add(platano);
                                break;
                            case 2:
                                Console.WriteLine("Compraste una semilla de manzana");
                                Console.WriteLine($"Gastastes $5 y ahora te queda ${dinero -= 5} de dinero");

                                Semilla manzana = new SemillaManzana("Semilla de manzana", 3);
                                semilla.Add(manzana);
                                break;
                            case 3:
                                return;

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

}

