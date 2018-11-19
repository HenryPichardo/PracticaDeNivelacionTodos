using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string [,] tabla = new string [2, 3];
            tabla[0, 0] = "Jose";
            tabla[0, 1] = "Pedro";
            tabla[0, 2] = "Juan";

            tabla[1, 0] = "Maria";
            tabla[1, 1] = "Jenny";
            tabla[1, 2] = "Martha";

            for (int f = 0; f < 2; f++)
            {
                Console.WriteLine("");
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine(tabla[f, c] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
