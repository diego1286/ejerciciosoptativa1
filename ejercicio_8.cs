using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_8
    {
        /*Calcula y muestra la suma de los números pares entre 1 y 50.*/
        public static void Ejecutar(){
            int suma = 0;

            for (int i = 2; i <= 50; i += 2)
            {
                suma += i;
            }

            Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");



        }
    }
}