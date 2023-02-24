using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18___Mayor_y_menor_peso_ratones
{
    internal class Ejercicio18
    {
        static void Main(string[] args)
        {
            /* 
                18. Se ingresan 50 datos (peso y edad) de ratones, mostrar la edad del ratón de mayor peso y la edad
                del de menor peso. 
            */

            int edadMayorPeso = 0, edadMenorPeso = 0;
            float maxPeso = 0, menPeso = 0;


            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"--------- Ratón {i + 1} ---------");
                Console.Write("Peso: ");
                float pesoRaton = float.Parse(Console.ReadLine());
                Console.Write("Edad: ");
                int edadRaton = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    edadMayorPeso = edadRaton;
                    maxPeso = pesoRaton;

                    edadMenorPeso = edadRaton;
                    menPeso = pesoRaton;
                }
                else
                {
                    if (pesoRaton > maxPeso)
                    {
                        maxPeso = pesoRaton;
                        edadMayorPeso = edadRaton;
                    }

                    if (pesoRaton < menPeso)
                    {
                        menPeso = pesoRaton;
                        edadMenorPeso = edadRaton;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"----------------------------");

            Console.WriteLine($"\nEdad del ratón de mayor peso: {edadMayorPeso} ({maxPeso} kg).");
            Console.WriteLine($"Edad del ratón con menor peso: {edadMenorPeso} ({menPeso} kg).");
        }
    }
}
