using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_5
    {
        public static void Ejecutar(){
            Console.Write("Ingresa un número (1-7): ");
            string entradaUsuario = Console.ReadLine();

        if (int.TryParse(entradaUsuario, out int numero))
        {
            if (numero >= 1 && numero <= 7)
            {
                string diaSemana;
                switch (numero)
                {
                    case 1:
                        diaSemana = "Lunes";
                        break;
                    case 2:
                        diaSemana = "Martes";
                        break;
                    case 3:
                        diaSemana = "Miércoles";
                        break;
                    case 4:
                        diaSemana = "Jueves";
                        break;
                    case 5:
                        diaSemana = "Viernes";
                        break;
                    case 6:
                    case 7:
                        diaSemana = null; 
                        break;
                    default:
                        diaSemana = null;
                        break;
                }

                if (diaSemana != null)
                {
                    Console.WriteLine($"El día laboral correspondiente es: {diaSemana}");
                }
                else
                {
                    Console.WriteLine("El número ingresado no corresponde a un día laboral.");
                }
            }
            else
            {
                Console.WriteLine("Número fuera de rango (1-7).");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
        }



        }
    }
}