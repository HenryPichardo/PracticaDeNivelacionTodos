using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sb = 0, sn = 0, dd = 0, ht = 0, th = 0;

            Console.WriteLine("Este programa calcula sueldo: ");
            Console.WriteLine("Introoduzca las horas trabajadas: ");
            ht = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introoduzca la tarifa por hora : ");
            th = Convert.ToDouble(Console.ReadLine());

            sb = th * ht;
            if (sb > 5000)
            {
                dd = sb * 10 / 100;
            }
            else
            {
                dd = sb * 5 / 100;
            }
            
            sn = sb - dd;

            Console.WriteLine("sueldo  bruto = " + sb);
            Console.WriteLine("descuento = " + dd);
            Console.WriteLine("sueldo neto = " + sn);

            Console.ReadLine();
        }
    }
}
