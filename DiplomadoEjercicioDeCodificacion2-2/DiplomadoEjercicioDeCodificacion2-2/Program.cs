using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaEnero = 0, notaFebrero = 0, notaMarzo = 0, notaAbril = 0, promedio = 0;

            Console.WriteLine("Este Programa calcula el promedio de cuatros notas");

            Console.WriteLine("Introduzca la primera nota ");
            notaEnero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca la segunda nota ");
            notaFebrero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca la tercera nota ");
            notaMarzo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca la cuarta nota ");
            notaAbril = Convert.ToDouble(Console.ReadLine());

            promedio = (notaEnero + notaFebrero + notaMarzo + notaAbril) / 4;

            Console.WriteLine("El resultado es : " + promedio);

            Console.ReadKey();
        }
    }
}
