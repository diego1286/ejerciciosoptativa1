using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ejercicio_c_
    {
        /*Solicita dos números 
        y muestra el residuo de la división del primero entre el segundo.*/
        public class ejercicio_7
        {
            public static void Ejecutar()
            {
                Console.Write("Ingresa el primer número: ");
                string entradaUsuario1 = Console.ReadLine();

                Console.Write("Ingresa el segundo número: ");
                string entradaUsuario2 = Console.ReadLine();

                if (int.TryParse(entradaUsuario1, out int numero1) && int.TryParse(entradaUsuario2, out int numero2))
                {
                    if (numero2 != 0)
                    {
                        int residuo = numero1 % numero2;
                        Console.WriteLine($"El residuo de la división de {numero1} entre {numero2} es: {residuo}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debes ingresar números enteros.");
                }
            }
        }
    }