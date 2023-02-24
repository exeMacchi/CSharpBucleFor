using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Imprimir_caracter
{
    internal class Ejercicio04
    {
        static void Main(string[] args)
        {
            /*
                4. Escriba un programa que pida al usuario un carácter y un número de repeticiones.
                   Luego imprima el carácter el número de veces especificado en una sola línea.
            */

            Console.Write("Ingrese un carácter: ");
            char letra = char.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de repeticiones: ");
            int repeticiones = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < repeticiones; i++)
            {
                Console.Write(letra);
            }
            Console.WriteLine();
        }
    }
}
