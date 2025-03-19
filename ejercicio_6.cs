using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Solicita al usuario su salario anual 
y, si este excede los 12000, muestra el impuesto a pagar que es el 15% del excedente. */

 namespace ejercicio_c_
    {
        public class ejercicio_6
        {
            public static void Ejecutar()
            {
                int salario;
                bool converse1;

                Console.Write("Ingrese su salario anual: "); 
                string sc1 = Console.ReadLine();
                converse1 = int.TryParse(sc1, out salario);

                if (converse1)
                {
                    if (salario > 12000)
                    {
                        double excedente = salario - 12000; 
                        double impuesto = excedente * 0.15; 

                        Console.WriteLine($"El impuesto a pagar es: {impuesto}");
                    }
                    else
                    {
                        Console.WriteLine("No debes pagar impuestos, tu salario no supera el tope.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debes ingresar un número entero."); // Agregado: manejo de error de conversión
                }
            }
        }
    }