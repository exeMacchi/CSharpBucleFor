using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11___Peso_promedio
{
    internal class Ejercicio11
    {
        static void Main(string[] args)
        {
            // 11. Se desea conocer el peso promedio de 20 personas.

            float pesoAcumulado = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Ingrese el peso (kg) de la persona {i + 1}: ");
                float peso = float.Parse(Console.ReadLine());

                pesoAcumulado += peso;
            }

            float promedio = pesoAcumulado / 20.0F;

            Console.WriteLine($"\nEl peso promedio de veinte personas es {promedio} kg.");
        }
    }
}
