using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombrePrducto = "";
            double precio = 0, cantidad = 0, itbis = 0, subTotal = 0, totalGeneral = 0;

            Console.WriteLine("Introduzca el nombre del producto : ");
            nombrePrducto = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca la cantidad : ");
            cantidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el precio : ");
            precio = Convert.ToDouble(Console.ReadLine());

            itbis = precio / 18 * 100;
            subTotal = precio * cantidad;
            totalGeneral = subTotal + itbis;
            
            
            Console.WriteLine("subtotal  = " + subTotal);
            Console.WriteLine("itbis =  "+itbis);
            Console.WriteLine("Total a pagar = "+ totalGeneral);

            Console.ReadKey();
        }
    }
}
