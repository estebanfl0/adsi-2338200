using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio09
    {
        static void Main(string[] args)
        {
            /*9. Escribir un programa que muestre el siguiente menú y que permita pasar magnitudes de grados a
            radianes y de radianes a grados.
            1. Pasar de grados a radianes
            2. Pasar de radianes a grados
            3. Salir del programa
            */

            double operación, num;
            int opcion; 
            do
            {
                Console.WriteLine("Que desea realizar. ");
                Console.WriteLine("1. Pasar de grados a radianes");
                Console.WriteLine("2.Pasar de radianes a grados");
                Console.WriteLine("3.Salir del programa");
                opcion = int.Parse(Console.ReadLine());
                if (opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("[ E R R O R ]");
                    Console.WriteLine("Que desea realizar. ");
                    Console.WriteLine("1. Pasar de grados a radianes");
                    Console.WriteLine("2.Pasar de radianes a grados");
                    Console.WriteLine("3.Salir del programa");
                }
                else if (opcion == 1)
                {
                    Console.WriteLine("Digite los grados que desea pasa a radianes");
                    num = double.Parse(Console.ReadLine());
                    operación = num * Math.PI / 180;
                    Console.WriteLine("El número en radianes es: " + operación);
                } else
                {
                    Console.WriteLine("Digite los radianes que desea pasar a grados");
                    num = double.Parse(Console.ReadLine());
                    operación = num  * 180 / Math.PI;
                    Console.WriteLine("El número en grados es: " + operación);
                }
                Console.WriteLine("\n");
            } while (opcion <3);
            Console.WriteLine("Fin del Proceso");
        }
    }
}
