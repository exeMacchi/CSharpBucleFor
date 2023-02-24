using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17___Hallar_datos_en_lista_de_numeros
{
    internal class Ejercicio17
    {
        static void Main(string[] args)
        {
            /* 
                17. Se ingresan 10 números para hallar tres datos:
                        a) La cantidad de números negativos.
                        b) La suma de los números que se encuentran entre el 1 y el 10 (no incluidos).
                        c) El promedio de todos los números.
            */

            int cantidadNumNegativos = 0, acumEntre1y10 = 0, acumNumeros = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                acumNumeros += numero;

                if (numero < 0)
                {
                    cantidadNumNegativos++;
                }
                else if (numero > 1 && numero < 10)
                {
                    acumEntre1y10 += numero;
                }
            }

            float promedio = acumNumeros / 10.0F;

            Console.WriteLine($"\nCantidad de números negativos: {cantidadNumNegativos}");
            Console.WriteLine($"La suma de números entre 1 y 10 (no incluidos): {acumEntre1y10}");
            Console.WriteLine($"Promedio de todos los números: {promedio}");
        }
    }
}
