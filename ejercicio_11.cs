using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_11
    {
        /* Pide al usuario cuatro números y muestra el promedio.*/
        public static void Ejecutar(){
            double suma = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Ingresa el número {i}: ");
                string entradaUsuario = Console.ReadLine();

                if (double.TryParse(entradaUsuario, out double numero))
                {
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debes ingresar un número.");
                    i--; 
                }
            }

            double promedio = suma / 4;
            Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
        }
    }
}