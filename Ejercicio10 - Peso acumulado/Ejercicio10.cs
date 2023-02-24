using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10___Peso_acumulado
{
    internal class Ejercicio10
    {
        static void Main(string[] args)
        {
            // 10. Se desea conocer el peso acumulado de 40 personas.

            int pesoAcumulado = 0;

            for (int i = 0; i < 40; i++)
            {
                Console.Write($"Ingrese el peso (kg) de la persona {i + 1}: ");
                int peso = int.Parse(Console.ReadLine());

                pesoAcumulado += peso;
            }

            Console.WriteLine($"\nEl peso acumulado de cuarenta personas: {pesoAcumulado} kg.");
        }
    }
}
