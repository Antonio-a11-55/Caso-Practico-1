using System;

namespace Caso_Práctico_1
{
    public class Menu
    {
        public static void Iniciar()
        {
            string opcion = "0";

            Console.WriteLine("Bienvenido al juego de operaciones matemáticas!");
            Console.WriteLine("\n Intrucciones: Elige un tipo de operación o el modo que corresponde a una operación aleatoria. \tResponde correctamente a las preguntas para ganar puntos. ¡Buena suerte!");

            do
            {
                Console.WriteLine("\n 1. Suma");
                Console.WriteLine("\n 2. Resta");
                Console.WriteLine("\n 3. Multiplicación");
                Console.WriteLine("\n 4. División");
                Console.WriteLine("\n 5. Aleatorio");
                Console.WriteLine("\n 6. Historial de juegos");
                Console.WriteLine("\n 7. Salir\n");

                Console.Write("Opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Has elegido la opción de suma.");
                        Juego.Suma();
                        break;
                    case "2":
                        Console.WriteLine("Has elegido la opción de resta.");
                        Juego.Resta();
                        break;
                    case "3":
                        Console.WriteLine("Has elegido la opción de multiplicación.");
                        Juego.Multiplicacion();
                        break;
                    case "4":
                        Console.WriteLine("Has elegido la opción de división.");
                        Juego.Division();
                        break;
                    case "5":
                        Console.WriteLine("Has elegido el modo aleatorio.");
                        Juego.Aleatorio();
                        break;
                    case "6":
                        Console.WriteLine("Mostrando historial...");
                        Historial.Mostrar();
                        break;
                    case "7":
                        Console.WriteLine("Saliendo del juego...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                        break;
                }

            } while (opcion != "7");
        }
    }
}