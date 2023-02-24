using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Maxima_temperatura
{
    internal class Ejercicio14
    {
        static void Main(string[] args)
        {
            // 14. Ingrese 10 temperaturas y muestre la mayor.

            float maxTemperatura = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. Ingrese la temperatura (ºC): ");
                float temperatura = float.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maxTemperatura = temperatura;
                }
                else if (temperatura > maxTemperatura)
                {
                    maxTemperatura = temperatura;
                }
            }

            Console.WriteLine($"\nLa temperatura máxima fue {maxTemperatura}ºC.");
        }
    }
}
