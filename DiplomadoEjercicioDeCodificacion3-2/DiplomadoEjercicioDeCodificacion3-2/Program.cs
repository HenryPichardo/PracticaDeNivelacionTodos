using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta aplicacion calcula el promedio de cuatro notas");

            int n1 = 0, n2 = 0, n3 = 0, p = 0, n4 = 0;

            Console.WriteLine("Introduzca la primera nota");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la segunda nota");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la tercera nota");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la cuarta nota");
            n4 = Convert.ToInt32(Console.ReadLine());

            p = (n1 + n2 + n3 + n4) / 4;

            if (p < 65)
            {
                Console.WriteLine("Reprobado");
            }
            else if (p > 65 && p <= 75)
            {
                Console.WriteLine("Aprobado");
            }
            else if (p > 75 && p <= 85)
            {
                Console.WriteLine("Muy bueno");
            }
            else if (p > 85 && p <= 90)
            {
                Console.WriteLine("Sobresaliente");
            }
            else if (p > 90 && p <= 100)
            {
                Console.WriteLine("Exelente");
            }
            Console.ReadKey();
            

        }
    }
}
