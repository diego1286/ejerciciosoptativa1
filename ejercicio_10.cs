using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_10
    {
        /*Pide una palabra al usuario y muestra la longitud de esa palabra.*/
        public static void Ejecutar(){

                Console.Write("Ingresa una palabra : ");
                string palabra = Console.ReadLine();

                if(!string.IsNullOrEmpty(palabra)){
                    int longitud = palabra.Length; // Corregido: "length" a "Length"
                    Console.WriteLine($"La longitud de la palabra es: {longitud}"); // corregido: longuitud a longitud
                }else{
                    Console.WriteLine("No ingresaste ninguna palabra.");
                }

        

        }
    }
}