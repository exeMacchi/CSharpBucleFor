using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___Mujeres_y_hombres_mayores_de_18
{
    internal class Ejercicio08
    {
        static void Main(string[] args)
        {
            /*
                8. Imprima la cantidad de mujeres mayores de edad y la cantidad de hombres mayores de edad de un
                   total de N personas. Muestre también sus porcentajes.
            */

            int cantidadMujeresMayores = 0, cantidadHombresMayores = 0;

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

                if (genero == 'H' || genero == 'h')
                {
                    if (edad >= 18)
                    {
                        cantidadHombresMayores++;
                    }
                }

                if (genero == 'M' || genero == 'm')
                {
                    if (edad >= 18)
                    {
                        cantidadMujeresMayores++;
                    }
                }
            }

            int porcentajeHombresMayores = (cantidadHombresMayores * 100) / totalPersonas;
            int porcentajeMujeresMayores = (cantidadMujeresMayores * 100) / totalPersonas;

            Console.WriteLine($"Cantidad de hombres mayores de edad: {cantidadHombresMayores}. " +
                              $"Esto representa el {porcentajeHombresMayores}% del total.");

            Console.WriteLine($"Cantidad de mujeres mayores de edad: {cantidadMujeresMayores}. " +
                              $"Esto representa el {porcentajeMujeresMayores}% del total.");
        }
    }
}
