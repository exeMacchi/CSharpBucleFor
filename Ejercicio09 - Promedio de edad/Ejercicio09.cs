using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Promedio_de_edad
{
    internal class Ejercicio09
    {
        static void Main(string[] args)
        {
            /* 
                9. A un grupo de 10 personas se le consulta la edad y se desea calcular su promedio de edad.
                   Muestre el promedio y cuántas de las 10 personas son mayores de 18 años.
            */

            int personasMayores = 0;
            int edades = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la edad de la persona {i + 1}: ");
                int edad = int.Parse(Console.ReadLine());

                edades += edad;

                if (edad >= 18)
                {
                    personasMayores++;
                }
            }

            float promedioEdad = edades / 10.0F;

            Console.WriteLine($"\nLa edad promedio es {promedioEdad}");
            Console.WriteLine($"Cantidad de personas mayores de edad: {personasMayores}");
        }
    }
}
