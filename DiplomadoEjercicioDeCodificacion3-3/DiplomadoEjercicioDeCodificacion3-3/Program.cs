using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad == 0)
            {
                Console.WriteLine("Bebe");
            }
            else if (edad == 1)
            {
                Console.WriteLine("Bebe");
            }
            else if (edad >= 2 && edad <=12 )
            {
                Console.WriteLine("Niño");
            }
            else if (edad >= 13 && edad <=17)
            {
                Console.WriteLine("Adolecente");
            }
            else if (edad >= 18 && edad >= 30)
            {
                Console.WriteLine("Joven");
            }
            else if (edad >= 31 && edad <= 64)
            {
                Console.WriteLine("Adulto");
            }
            else if (edad >= 65 && edad <= 120)
            {
                Console.WriteLine("Anciano");
            }
            else if (edad < 0 && edad > 125)
            {
                Console.WriteLine("Error edad incorrecta");
            }

            {
                Console.ReadKey();
            }
        }

    }
}
