using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Mayores_de_18
{
    internal class Ejercicio06
    {
        static void Main(string[] args)
        {
            // 6. Imprima la cantidad de personas mayores de edad (>=18) de un total de N personas.

            Console.Write("Cantidad total de personas: ");
            int totalPersonas = int.Parse(Console.ReadLine());

            int personasMayores = 0;

            for (int i = 0; i < totalPersonas; i++)
            {
                Console.Write($"{i + 1}. Ingrese la edad de la persona: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    personasMayores++;
                }
            }

            Console.WriteLine($"\nCantidad total de personas mayores de edad: {personasMayores}");
        }
    }
}
