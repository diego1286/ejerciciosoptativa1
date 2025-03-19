using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_13
    {
        /*Pide una palabra al 
        usuario y devuelve el número de vocales en esa palabra. */
        public static void Ejecutar(){
            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine().ToLower(); 

            int contadorVocales = 0;
            foreach (char caracter in palabra)
            {
                if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine($"La palabra '{palabra}' tiene {contadorVocales} vocales.");

        }
    }
}