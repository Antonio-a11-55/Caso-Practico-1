using Caso_Práctico_1;
using System;

namespace Caso_Práctico_1
{
    public class Juego
    {
        static Random rnd = new Random();

        public static void Suma()
        {
            int puntos = 0;

            // Hacemos cinco preguntas para que la partida sea corta y fácil de seguir.
            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(0, 101);
                int b = rnd.Next(0, 101);
                int resultado = a + b;

                Console.Write($"\nPregunta {i + 1}: ¿{a} + {b} = ? ");
                string entrada = Console.ReadLine();

                //Si la respuesta es correcta, sumamos un punto al contador de puntos. Si no, mostramos la respuesta correcta.
                int respuesta;
                if (int.TryParse(entrada, out respuesta) && respuesta == resultado)
                {
                    Console.WriteLine("¡Correcto! +1 punto");
                    puntos++;
                }
                else
                {
                    Console.WriteLine($"Incorrecto. La respuesta era {resultado}");
                }
            }

            Console.WriteLine($"\nHas acertado {puntos} de 5.");
            Historial.Agregar($"Suma -> {puntos}/5");
        }

        public static void Resta()
        {
            int puntos = 0;

            //Lo mismo que en la resta y la suma, hacemos cinco preguntas y validamos la respuesta del usuario, si es correcta sumamos un punto, si no mostramos la respuesta correcta.
            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(0, 101);
                int b = rnd.Next(0, 101);

                // Ponemos el número mayor delante para que la resta no salga negativa.
                if (a < b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                int resultado = a - b;

                Console.Write($"\nPregunta {i + 1}: ¿{a} - {b} = ? ");
                string entrada = Console.ReadLine();

                int respuesta;
                if (int.TryParse(entrada, out respuesta) && respuesta == resultado)
                {
                    Console.WriteLine("¡Correcto! +1 punto");
                    puntos++;
                }
                else
                {
                    Console.WriteLine($"Incorrecto. La respuesta era {resultado}");
                }
            }

            Console.WriteLine($"\nHas acertado {puntos} de 5.");
            Historial.Agregar($"Resta -> {puntos}/5");
        }

        public static void Multiplicacion()
        {
            int puntos = 0;

            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(0, 11);
                int b = rnd.Next(0, 11);
                int resultado = a * b;

                Console.Write($"\nPregunta {i + 1}: ¿{a} x {b} = ? ");
                string entrada = Console.ReadLine();

                int respuesta;
                if (int.TryParse(entrada, out respuesta) && respuesta == resultado)
                {
                    Console.WriteLine("¡Correcto! +1 punto");
                    puntos++;
                }
                else
                {
                    Console.WriteLine($"Incorrecto. La respuesta era {resultado}");
                }
            }

            Console.WriteLine($"\nHas acertado {puntos} de 5.");
            Historial.Agregar($"Multiplicación -> {puntos}/5");
        }

        public static void Division()
        {
            int puntos = 0;

            for (int i = 0; i < 5; i++)
            {
                int divisor, resultado, dividendo;

                // Creamos la división a partir del resultado para que siempre sea exacta.
                do
                {
                    divisor = rnd.Next(1, 11);
                    resultado = rnd.Next(0, 11);
                    dividendo = divisor * resultado;
                } while (dividendo > 100);

                Console.Write($"\nPregunta {i + 1}: ¿{dividendo} / {divisor} = ? ");
                string entrada = Console.ReadLine();

                int respuesta;
                if (int.TryParse(entrada, out respuesta) && respuesta == resultado)
                {
                    Console.WriteLine("¡Correcto! +1 punto");
                    puntos++;
                }
                else
                {
                    Console.WriteLine($"Incorrecto. La respuesta era {resultado}");
                }
            }

            Console.WriteLine($"\nHas acertado {puntos} de 5.");
            Historial.Agregar($"División -> {puntos}/5");
        }

        public static void Aleatorio()
        {
            // Elegimos una operación al azar y la ponemos en marcha.
            int tipo = rnd.Next(1, 5);

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("Modo aleatorio: SUMAS");
                    Suma();
                    break;
                case 2:
                    Console.WriteLine("Modo aleatorio: RESTAS");
                    Resta();
                    break;
                case 3:
                    Console.WriteLine("Modo aleatorio: MULTIPLICACIONES");
                    Multiplicacion();
                    break;
                case 4:
                    Console.WriteLine("Modo aleatorio: DIVISIONES");
                    Division();
                    break;
            }
        }
    }
}