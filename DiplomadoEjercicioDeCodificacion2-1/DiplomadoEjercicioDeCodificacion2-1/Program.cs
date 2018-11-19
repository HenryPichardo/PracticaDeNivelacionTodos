using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";

            Console.WriteLine("Introduzca su nombre:");
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Saludos señor :"+ nombre);
            Console.ReadKey();
        }
    }
}
