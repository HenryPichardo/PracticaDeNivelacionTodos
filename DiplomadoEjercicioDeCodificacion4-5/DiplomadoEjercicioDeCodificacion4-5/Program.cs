using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int r;

            for (int i = 1; i <= 12; i++)
            {
                for (int t = 1; t <= 12; t++)
                {
                
                r = t * i;
                Console.WriteLine(i + " x " + t + " = " + r);
                 }
            }
            Console.ReadKey();
        }
    }
}
