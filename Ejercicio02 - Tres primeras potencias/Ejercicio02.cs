using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Tres_primeras_potencias
{
    internal class Ejercicio02
    {
        static void Main(string[] args)
        {
            // 2. Imprima las tres primeras potencias de los números del 1 al 10.

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} elevado a 1 = {i}");
                Console.WriteLine($"{i} elevado al cuadrado = {i * i}");
                Console.WriteLine($"{i} elevado al cubo = {i * i * i}");
                Console.WriteLine();
            }
        }
    }
}
