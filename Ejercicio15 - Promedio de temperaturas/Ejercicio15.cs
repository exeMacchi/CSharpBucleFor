using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15___Promedio_de_temperaturas
{
    internal class Ejercicio15
    {
        static void Main(string[] args)
        {
            /*
                15. Se ingresan 10 pares de temperaturas (T1 y T2). Halle el promedio de las temperaturas T1 y el
                    promedio de las temperaturas T2. 
            */

            float acumuladoT1 = 0, acumuladoT2 = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write($"{x + 1}. Ingrese la temperatura en centígrados (T{i + 1}): ");
                    float temperatura = float.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        acumuladoT1 += temperatura;
                    }
                    else
                    {
                        acumuladoT2 += temperatura;
                    }
                }
                Console.WriteLine();
            }

            float promedioT1 = acumuladoT1 / 10.0F;
            float promedioT2 = acumuladoT2 / 10.0F;

            Console.WriteLine($"Promedio de temperatura (T1): {Math.Round(promedioT1, 1)}ºC.");
            Console.WriteLine($"Promedio de temperatura (T2): {Math.Round(promedioT2, 1)}ºC.");
        }
    }
}
