using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    /*Pide un número al usuario y devuelve el factorial de ese número.*/
    public class ejercicio_14
    {
        public static void Ejecutar(){
            Console.Write("Ingresa un número entero: ");
            string entradaUsuario = Console.ReadLine();

            if (int.TryParse(entradaUsuario, out int numero) && numero >= 0)
            {
                long factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número entero no negativo.");
            }

        }
    }
}