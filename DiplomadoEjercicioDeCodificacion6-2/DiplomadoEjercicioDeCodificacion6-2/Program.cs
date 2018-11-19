using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            int[] vector = new int[5];
            double sumatoria = 0;

            Console.WriteLine("crearemos un arreglo de 5 elementos ");



            Console.WriteLine("Introduzca el primer elemento ");
            vector[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo elemento ");
            vector[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer elemento ");
            vector[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el cuarto elemento ");
            vector[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el quinto elemento");
            vector[4] = Convert.ToInt32(Console.ReadLine());
            sumatoria = vector[0] + vector[1] + vector[2] + vector[3] + vector[4];


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Los elementos del vector son: " + vector[i]);
            }
            Console.WriteLine(" La sumatoria de todos los elementos es = " + sumatoria);
            Console.ReadLine();
        }
    }
}
