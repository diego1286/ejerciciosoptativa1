using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_c_
{
    public class ejercicio_2
    {
            public static void Ejecutar()
            {
                /*Solicita al usuario dos números. Si el primero es mayor, 
                devuelva su doble, de lo contrario devuelva el triple del segundo. 
                */
                int numero1;
                int numero2;
                bool converse1;
                bool converse2;

                Console.Write("Ingrese un numero");
                String sc1= Console.ReadLine();
                converse1= int.TryParse(sc1, out numero1);

                Console.Write("Ingrese un numero");
                String sc2= Console.ReadLine();
                converse2= int.TryParse(sc2, out numero2);

                if( converse1 && converse2){
                    if( numero1> numero2){
                        int result = (numero1* 2);
                        Console.WriteLine($"{result} es el doble de  {numero1}");
                    }
                    else if(numero1 < numero2){
                        int result2= (numero2 *3);
                        Console.WriteLine($"{numero2} es mayor que {numero1} y su triple es {result2}");

                    }else{
                        Console.WriteLine($"{numero1} es igual a {numero2}");
                    }

                }else{
                    Console.Write("No es un numero");
                }

            

            }
    }
}