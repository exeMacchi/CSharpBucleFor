using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___Volumen_total_barriles
{
    internal class Ejercicio13
    {
        static void Main(string[] args)
        {
            /* 
                13. En un depósito se reciben 10 barriles de lubricantes para una fábrica de rulemanes y se desea
                    conocer el volumen total que ocuparán. Existen 4 tipos de barriles (de 25, 40, 50 y 100 litros)
                    que se identifican con A, B, C y D, respectivamente. 
            */

            int volumenTotal = 0;

            const int CatA = 25, CatB = 40, CatC = 50, CatD = 100;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. Ingrese la categoría del barril (A, B, C or D): ");
                char categoria = char.Parse(Console.ReadLine());

                switch (categoria)
                {
                    case 'A': case 'a':
                        volumenTotal += CatA;
                        break;

                    case 'B': case 'b':
                        volumenTotal += CatB;
                        break;

                    case 'C': case 'c':
                        volumenTotal += CatC;
                        break;

                    case 'D': case 'd':
                        volumenTotal += CatD;
                        break;

                    default:
                        Console.WriteLine("Categoría introducida incorrecta.");
                        volumenTotal += 0;
                        break;
                }

            }

            Console.WriteLine($"\nVolumen total que ocupan: {volumenTotal} litros.");
        }
    }
}
