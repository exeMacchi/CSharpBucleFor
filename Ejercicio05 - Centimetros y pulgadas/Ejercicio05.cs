using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Centimetros_y_pulgadas
{
    internal class Ejercicio05
    {
        static void Main(string[] args)
        {
            /*
                5. Imprima dos columnas, una en centímetros y la otra en su equivalente en pulgadas.
                   Los centímetros se ingresan por teclado.
            */

            Console.Write("Ingrese el número de repeticiones: ");
            int repeticiones = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeticiones; i++)
            {
                Console.Write("Ingrese el tamaño en centímetros: ");
                float centrimetros = float.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"{centrimetros} cm -----> {Math.Round((centrimetros / 2.54), 2)} pulgadas");
                Console.WriteLine();
            }
        }
    }
}
