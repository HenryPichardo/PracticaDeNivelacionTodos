using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            for ( int i = 100; i >99 && i <106; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
