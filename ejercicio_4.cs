using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_4
    {
        public static void Ejecutar(){
            /* Pide al usuario el radio de un círculo y calcula su perímetro.*/

            Console.Write("Ingresa el radio del círculo: ");
            string entradaUsuario = Console.ReadLine();

            if (double.TryParse(entradaUsuario, out double radio))
            {
                if (radio >= 0)
                {
                    double perimetro = 2 * Math.PI * radio;
                    Console.WriteLine($"El perímetro del círculo es: {perimetro}");
                }
                else
                {
                    Console.WriteLine("El radio debe ser un número no negativo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número válido.");
            }


        }
    }
}