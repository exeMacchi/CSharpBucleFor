using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___Menores_de_18
{
    internal class Ejercicio07
    {
        static void Main(string[] args)
        {
            /*
                7. Imprima la cantidad de mujeres menores de edad de un total de N personas. Muestre también
                   su porcentaje.
            */

            int cantidadMujeresMenores = 0;

            Console.Write("Cantidad total de personas: ");
            int totalPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < totalPersonas; i++)
            {
                Console.Write($"¿La persona {i + 1} es hombre o mujer? ('H' = Hombre / 'M' = Mujer): ");
                char genero = char.Parse(Console.ReadLine());

                Console.Write("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (genero == 'M' || genero == 'm')
                {
                    if (edad < 18)
                    {
                        cantidadMujeresMenores++;
                    }
                }
            }

            int porcentajeMujeresMenores = (cantidadMujeresMenores * 100) / totalPersonas;

            Console.WriteLine($"Cantidad de mujeres menores de edad: {cantidadMujeresMenores}. " +
                              $"Esto representa el {porcentajeMujeresMenores}% del total.");
        }
    }
}
