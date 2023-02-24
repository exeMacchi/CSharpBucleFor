using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___Peso_acumulado_en_libras
{
    internal class Ejercicio12
    {
        static void Main(string[] args)
        {
            /*
                12. Se desea conocer el peso acumulado de 15 materiales metálicos en libras (los datos se reciben en kg).
                    Una libra → 0,45359237 kg.
            */

            float pesoAcumulado = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Ingrese el peso (kg) del material metálico {i + 1}: ");
                float peso = float.Parse(Console.ReadLine());

                pesoAcumulado += peso;
            }

            pesoAcumulado *= 2.205F;

            Console.WriteLine($"\nPeso acumulado de quince materiales metálicos en libras: " +
                              $"{Math.Round(pesoAcumulado, 2)}");
        }
    }
}
