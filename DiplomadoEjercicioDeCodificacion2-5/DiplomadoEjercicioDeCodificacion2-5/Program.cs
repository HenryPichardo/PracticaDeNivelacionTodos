using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double cm = 0, pulg = 0;
            Console.WriteLine("Este programa convierte de centimetros a pulgadas");
            Console.WriteLine("Introduzca la cantidad de centimetros: ");
            cm = Convert.ToDouble(Console.ReadLine());
            pulg = cm / 2.54;

            Console.WriteLine("eso es igual a "+pulg+ "pulgadas");

            Console.ReadLine();


        }
    }
}
