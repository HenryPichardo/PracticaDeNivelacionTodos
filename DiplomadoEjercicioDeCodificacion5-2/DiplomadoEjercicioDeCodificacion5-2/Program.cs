using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string p = "";
            do
            {
                Console.WriteLine("☺==========MENU DE OPCIONES============☺");
                Console.WriteLine("☺==========TABLA DE MULTIPLICAR [T]============☺");
                Console.WriteLine("☺==========CALULAR PROMEDIO     [P]============☺");
                Console.WriteLine("☺==========SALIR                [S]============☺");
                Console.WriteLine("☺==========ELIJA UNA OPCION============☺");
                p = Console.ReadLine();
                switch (p)
                {
                    case "t":
                    case "T":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();

                        int r = 0, tabla = 0, i = 0;
                        Console.WriteLine("ahora elija el numero de la tabla de multiplicar que desea visualizar");
                        tabla = Convert.ToInt32(Console.ReadLine());

                        while (i <= 12)
                        {
                            r = tabla * i;
                            Console.WriteLine(tabla + " X " + i + " = " + r);
                            i++;

                        }
                        break;
                    case "p":
                    case "P":
                        Console.WriteLine("Ahora puede calcular promedio :");
                        int x = 1, n = 0, prom = 0, valor = 0, totalValores = 0;
                        Console.WriteLine("Cuantos valores desea ingresar");
                        n = Convert.ToInt32(Console.ReadLine());
                        while (x <= n)
                        {
                            Console.WriteLine("Introduzca el valor # " + x);
                            valor = Convert.ToInt32(Console.ReadLine());
                            totalValores = totalValores + valor;
                            x = x + 1;
                        }
                        prom = totalValores / n;
                        Console.WriteLine("El promedio es = " + prom);
                        
                        break;
                    default:
                        Console.WriteLine("Adios...");
                        p = "s";
                        break;

                }
            } while (p != "s" && p != "S");
        }
    }
}
