using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuota = 0, monto = 0, interes = 0, tiempo = 0;

            Console.WriteLine("Este programa calcula la cuota de un prestamo:");
            Console.WriteLine("Introduzca el monto:");
            monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el interes:");
            interes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el tiempo:");
            tiempo = Convert.ToDouble(Console.ReadLine());

            cuota = (monto * interes / tiempo) + (monto / tiempo);

            Console.WriteLine("la cuota sera : " +cuota);
            Console.ReadLine();

        }
    }
}
