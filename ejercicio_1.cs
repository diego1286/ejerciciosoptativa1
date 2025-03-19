using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_1
    {
    public static void Ejecutar()
        {
            /*Solicita al usuario un número y eleva este número al cuadrado solo si es positivo. */

        int numero;
        bool ConversionNum;

        Console.Write("Ingresa un numero: ");
        string sc = Console.ReadLine();

        ConversionNum = int.TryParse(sc, out numero);

        if (ConversionNum && numero > 0)
        {
            int cuadrado = numero * numero;
            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
        }
        else
        {
            Console.WriteLine("Número no positivo, Invalido numero");
        }

        }
    }
}