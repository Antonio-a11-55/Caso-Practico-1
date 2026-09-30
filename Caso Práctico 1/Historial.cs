using System;
using System.Collections.Generic;

namespace Caso_Práctico_1
{
    public class Historial
    {
        static List<string> partidas = new List<string>();

        public static void Agregar(string partida)
        {
            partidas.Add(partida);
        }

        public static void Mostrar()
        {
            if (partidas.Count == 0)
            {
                Console.WriteLine("Todavía no has jugado ninguna partida.");
            }
            else
            {
                Console.WriteLine("\n--- HISTORIAL DE PARTIDAS ---");
                for (int i = 0; i < partidas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {partidas[i]}");
                }
            }
        }
    }
}