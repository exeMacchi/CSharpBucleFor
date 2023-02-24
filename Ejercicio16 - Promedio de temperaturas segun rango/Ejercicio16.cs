using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Promedio_de_temperaturas_segun_rango
{
    internal class Ejercicio16
    {
        static void Main(string[] args)
        {
            /* 
                16. Se ingresan 10 pares de temperaturas (T1 y T2) para hallar el promedio de las temperaturas que
                    están entre 5° y 15° (incluidos).
            */

            float acumuladoT1 = 0, acumuladoT2 = 0;
            int contadorT1 = 0, contadorT2 = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write($"{x + 1}. Ingrese la temperatura en centígrados (T{i + 1}): ");
                    float temperatura = float.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        if (temperatura >= 5 && temperatura <= 15)
                        {
                            acumuladoT1 += temperatura;
                            contadorT1++;
                        }
                    }
                    else
                    {
                        if (temperatura >= 5 && temperatura <= 15)
                        {
                            acumuladoT2 += temperatura;
                            contadorT2++;
                        }
                    }
                }
                Console.WriteLine();
            }

            float promedioT1 = acumuladoT1 / contadorT1;
            float promedioT2 = acumuladoT2 / contadorT2;

            Console.WriteLine($"Promedio de temperatura entre 5°C y 15°C (T1): {Math.Round(promedioT1, 1)}ºC.");
            Console.WriteLine($"Promedio de temperatura entre 5°C y 15°C (T2): {Math.Round(promedioT2, 1)}ºC.");
        }
    }
}
