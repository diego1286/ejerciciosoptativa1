using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_12
    {
        /*Pide al usuario cinco números y muestra el más pequeño.*/
        public static void Ejecutar(){

                  int numeroMenor = int.MaxValue; 

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingresa el número {i}: ");
                string entradaUsuario = Console.ReadLine();

                if (int.TryParse(entradaUsuario, out int numero))
                {
                    if (numero < numeroMenor)
                    {
                        numeroMenor = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
                    i--; 
                }
            }

            Console.WriteLine($"El número más pequeño es: {numeroMenor}");


        }
        
    }
}