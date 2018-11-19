using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            int r = 0, t = 4,i = 0;

            while (i <= 12)
            {
                r = t * i;
                Console.WriteLine(t+" X "+i+" = "+r);
                i++;
            }
            Console.ReadKey();

        }
    }
}
