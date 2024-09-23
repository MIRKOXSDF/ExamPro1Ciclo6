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
        Inventario inventario;
        public void Game()
        {
            animal = new List<Animal>();
            semilla = new List<Semilla>();
            inventario = new Inventario();
            Console.WriteLine("Coloca el nombre del granjero : ");
            string nombre = Console.ReadLine();
            bool active = true;
            while (active)
            {

                try
                {
                    Console.WriteLine("Coloca la cantidad de dinero : ");
                    dinero = float.Parse(Console.ReadLine());
                    if (dinero < 100)
                    {
                        
                        Console.WriteLine("Entrada no válida.El numero debe ser positivo o mayor a 100");
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
                    Console.WriteLine("4. Ver Inventario");
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
                        case 4:
                            if(inventario!=null)
                            {
                                inventario.MostrarInventario();

                            }
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
            bool active = true;

            try
            {
          

                while (active)
                {
                    Console.WriteLine("¿Qué te gustaría hacer?");
                    Console.WriteLine("1. Sembrar semilla");
                    Console.WriteLine("2. Criar animales");
                    Console.WriteLine("3. Salir");
                    int option = int.Parse(Console.ReadLine());
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
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige 1 , 2 o 3 .");
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Elige un numero entero");

            }

        }
        private void SembrarSemilla()
        {
            if (semilla.Count == 0)
            {
                Console.WriteLine("No tienes semillas para plantar.");
                return;
            }

            Console.WriteLine("Selecciona una semilla para sembrar:");
            for (int i = 0; i < semilla.Count; i++)
            {
                Semilla s = semilla[i];
                Console.WriteLine($"{i + 1}. {s.nombre}");
            }

            try
            {
                int opcion = int.Parse(Console.ReadLine()) - 1;
                Semilla seleccion = semilla[opcion];

                seleccion.Crecer();   
                seleccion.Cosechar();
                if (seleccion.crecimientoActual >= seleccion.tiempoCrecimiento)
                {
                    semilla.RemoveAt(opcion);
                    VerificarVictoria(); 

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Elige un número entero válido.");
            }
        }
        private void CriarAnimales()
        {
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
                int opcion = int.Parse(Console.ReadLine()) - 1;

                Animal seleccion = animal[opcion];

                if (seleccion.reproduccionActual >= seleccion.tiempoCrecimiento)
                {
                    seleccion.EliminarAnimal();
                    animal.RemoveAt(opcion);
                    VerificarVictoria();

                }
                else
                {
                    seleccion.Ordeñar();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Elige un número entero válido.");
            }


        }
        private void ComprarAnimal()
        {
            bool active = true;
            while (active)
            {
                Console.WriteLine("Escoge tu animal :");
                Console.WriteLine("1. Vaca ($30)");
                Console.WriteLine("2. Gallina ($10)");
                Console.WriteLine("3. Cerdo ($20)");
                Console.WriteLine("4. Lista de Animales obtenidos : ");
                Console.WriteLine("5. Salir ");

                int option = int.Parse(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            if(dinero>=30)
                            {
                                Console.WriteLine("Compraste una vaca");
                                Console.WriteLine($"Gastastes $30 y ahora te queda ${dinero -= 30} de dinero");

                                Animal vaca = new Vaca("Vaca", inventario);
                                animal.Add(vaca);
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero.");
                                VerificarPerdida();
                            }

                            break;
                        case 2:
                            if(dinero>=10)
                            {
                                Console.WriteLine("Compraste una gallina");
                                Console.WriteLine($"Gastastes $10 y ahora te queda ${dinero -= 10} de dinero");

                                Animal gallina = new Gallina("Gallina", inventario);
                                animal.Add(gallina);
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero.");
                                VerificarPerdida();
                            }


                            break;
                        case 3:
                            if(dinero>=20)
                            {
                                Console.WriteLine("Compraste un cerdo");
                                Console.WriteLine($"Gastastes $20 y ahora te queda ${dinero -= 20} de dinero");

                                Animal cerdo = new Cerdo("Cerdo", inventario);
                                animal.Add(cerdo);
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero.");
                                VerificarPerdida();
                            }
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
                Console.WriteLine("3. Lista de Semillas obtenidos : ");
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
                Console.WriteLine("1. Semilla de platano ($10)");
                Console.WriteLine("2. Semilla de manzana ($5)");
                Console.WriteLine("3. Salir ");

                int option = int.Parse(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            if(dinero>=10)
                            {
                                Console.WriteLine("Compraste una semilla de platano");
                                Console.WriteLine($"Gastastes $10 y ahora te queda ${dinero -= 10} de dinero");

                                Semilla platano = new SemillaPlatano("Semilla de platano", 4, inventario);
                                semilla.Add(platano);
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero.");
                                VerificarPerdida();
                            }

                            break;
                        case 2:
                            if(dinero>=5)
                            {
                                Console.WriteLine("Compraste una semilla de manzana");
                                Console.WriteLine($"Gastastes $5 y ahora te queda ${dinero -= 5} de dinero");

                                Semilla manzana = new SemillaManzana("Semilla de manzana", 3, inventario);
                                semilla.Add(manzana);
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero.");
                                VerificarPerdida();
                            }

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
                Console.WriteLine("1. Semilla de papa ($20)");
                Console.WriteLine("2. Semilla de lechuga ($10)");
                Console.WriteLine("3. Salir ");

                int option = int.Parse(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            if(dinero>=20)
                            {
                                Console.WriteLine("Compraste una semilla de papa");
                                Console.WriteLine($"Gastastes $20 y ahora te queda ${dinero -= 20} de dinero");
                                Semilla papa = new SemillaDePapa("Semilla de papa", 5, inventario);
                                semilla.Add(papa);
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero.");
                                VerificarPerdida();
                            }


                            break;
                        case 2:
                            if(dinero>=10)
                            {
                                Console.WriteLine("Compraste una semilla de lechuga");
                                Console.WriteLine($"Gastastes $10 y ahora te queda ${dinero -= 10} de dinero");
                                Semilla lechuga = new SemillaLechuga("Semilla de lechuga", 3, inventario);
                                semilla.Add(lechuga);
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero.");
                                VerificarPerdida();
                            }



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
        private void VerificarVictoria()
        {
            if (animal.Count == 0 && semilla.Count == 0)
            {
                Console.WriteLine("¡Has ganado! No te queda ninguna semilla o animal vivo.");
                Environment.Exit(0);


            }
        }
        private void VerificarPerdida()
        {
            if (dinero < 5)
            {
                Console.WriteLine("¡Has perdido! No te queda dinero.");
                Environment.Exit(0); 
            }
        }
    }
}
