using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificaion4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            int cubo;

            for (int i = 3; i < 20; i++)
            {
                cubo = i * i * i;

                Console.WriteLine(i+" Cubo = "+ cubo);
            }
            Console.ReadKey();

        }
    }
}
