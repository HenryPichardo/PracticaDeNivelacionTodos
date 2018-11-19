using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoEjercicioDeCodificacion6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int[,] tabla1 = new int[2, 2];
            int[,] tabla2 = new int[2, 2];
            int[,] tabla3 = new int[2, 2];
            Console.WriteLine("Esta aplicacion muestra el resultado de la suma de dos matrices :");
            Console.WriteLine("");
            
            tabla1[0, 0] = 70;
            tabla1[0, 1] = 60;
            tabla1[1, 0] = 80;
            tabla1[1, 1] = 70;

            Console.WriteLine("Matriz A");
            for (int f = 0; f < 2; f++)
            {  
                for (int c = 0; c < 2; c++)
                {
                    Console.WriteLine(tabla1[f, c] );
                }
            }
                tabla2[0, 0] = 68;
                tabla2[0, 1] = 90;
                tabla2[1, 0] = 80;
                tabla2[1, 1] = 70;
            Console.WriteLine("");
            Console.WriteLine("Matri B");
            for (int f2 = 0; f2 < 2; f2++)
            {
                Console.WriteLine("");
                for (int c = 0; c < 2; c++)
                {
                        Console.Write(tabla2[f2,c] +" ");
                }
            }
                tabla3[0, 0] = 70+68;
                tabla3[0, 1] = 60+90;
                tabla3[1, 0] = 80+80;
                tabla3[1, 1] = 70+70;

            Console.WriteLine("");
            Console.WriteLine("La suma delas dos matrices es");
            
            Console.WriteLine("Matriz C");
            for (int t3 = 0; t3 < 2; t3++)
                {                               
                for (int f3 = 0; f3 < 2; f3++)
                    {                    
                        Console.WriteLine(tabla3[t3,f3]);
                    }
                }            
            Console.ReadKey();
        }
    }
}
