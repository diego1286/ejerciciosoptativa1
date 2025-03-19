using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
        /* */

    public class ejercicio_9
    {
        public static void Ejecutar()
        {
            
            Console.Write("Ingrese el numerador de la primera fracción: ");
            string numerador1Str = Console.ReadLine();
            Console.Write("Ingrese el denominador de la primera fracción: ");
            string denominador1Str = Console.ReadLine();

            // Solicitar la segunda fracción
            Console.Write("Ingrese el numerador de la segunda fracción: ");
            string numerador2Str = Console.ReadLine();
            Console.Write("Ingrese el denominador de la segunda fracción: ");
            string denominador2Str = Console.ReadLine();

            // Convertir las entradas a números enteros
            if (int.TryParse(numerador1Str, out int numerador1) &&
                int.TryParse(denominador1Str, out int denominador1) &&
                int.TryParse(numerador2Str, out int numerador2) &&
                int.TryParse(denominador2Str, out int denominador2))
            {
                // Calcular la diferencia de las fracciones
                int numeradorDiferencia = (numerador1 * denominador2) - (numerador2 * denominador1);
                int denominadorDiferencia = denominador1 * denominador2;

                // Mostrar el resultado
                Console.WriteLine($"La diferencia es: {numeradorDiferencia}/{denominadorDiferencia}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Asegúrese de ingresar números enteros.");
            }
        } 
    }
}
