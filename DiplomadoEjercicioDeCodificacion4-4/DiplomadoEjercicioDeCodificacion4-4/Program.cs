using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                int r = 4 * i;
                Console.WriteLine("4 x " + i + " = " + r);
            }
            Console.ReadKey();

        }
    }
}
