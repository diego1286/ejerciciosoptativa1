using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_15
    {
        /* */
        public static void Ejecutar(){
            Console.Write("Ingresa un número: ");
            string entradaUsuario = Console.ReadLine();

            if (int.TryParse(entradaUsuario, out int numero))
            {
                if (numero >= 10 && numero <= 20)
                {
                    Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
                }
                else
                {
                    Console.WriteLine($"El número {numero} no está en el rango de 10 a 20.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
            }

        }
    }
}