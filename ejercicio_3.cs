using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_3
    {
        public static void Ejecutar(){
            /*Pide al usuario un número. 
            Si es positivo, devuelve su raíz cuadrada, de lo contrario, 
            devuelve su cuadrado.
            */
        int numero1;
        bool converse1;

    Console.Write("Ingrese un numero: ");
    string sc1 = Console.ReadLine();
    converse1 = int.TryParse(sc1, out numero1);

    if (converse1)
    {
        if (numero1 > 0)
        {
            double raiz_cuadrada = Math.Sqrt(numero1);
            Console.WriteLine($"{raiz_cuadrada} es la raiz cuadrada de : {numero1}"); // Corregido: result a raiz_cuadrada
        }
        else if (numero1 < 0)
        {
            int result2 = (numero1 * numero1);
            Console.WriteLine($"{result2} es el cuadrado de : {numero1}");
        }
        else
        {
            Console.WriteLine($"{numero1} es cero."); 
        }
    }
    else
    {
        Console.WriteLine("No es un numero");
    }

        }
    }
}