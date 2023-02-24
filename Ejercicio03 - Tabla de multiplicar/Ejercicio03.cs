using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Tabla_de_multiplicar
{
    internal class Ejercicio03
    {
        static void Main(string[] args)
        {
            // 3. Dado un número imprima su tabla de multiplicar (del 0 a 10).

            Console.Write("Introduzca el número sobre el que desea saber su tabla de multiplicar: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{N} x {i} = {N * i}");
            }
        }
    }
}
