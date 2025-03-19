using ejercicio_c_;


 public class Program
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Elige el ejercicio que deseas realizar del numero 1 al 15:");
            int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: ejercicio_1.Ejecutar(); 
                break;
            case 2: ejercicio_2.Ejecutar();
                break;
            case 3: ejercicio_3.Ejecutar();
                break;
            case 4: ejercicio_4.Ejecutar();
                break;
            case 5: ejercicio_5.Ejecutar();
                break;
            case 6: ejercicio_6.Ejecutar();
                break;
            case 7: ejercicio_7.Ejecutar();
                break;
            case 8: ejercicio_8.Ejecutar();
                break;
            case 9: ejercicio_9.Ejecutar();
                break;
            case 10: ejercicio_10.Ejecutar();
                break;
            case 11: ejercicio_11.Ejecutar();
                break;
            case 12: ejercicio_12.Ejecutar();
                break;
            case 13: ejercicio_13.Ejecutar();
                break;
            case 14: ejercicio_14.Ejecutar();
                break;
            case 15: ejercicio_15.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida."); 
                break;
        }
        Console.ReadKey();
        }
    }
