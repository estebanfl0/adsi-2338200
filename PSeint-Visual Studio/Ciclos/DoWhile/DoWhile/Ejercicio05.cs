using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio05
    {
        static void MainTemporal(string[] args)
        {
            /*5. Calcular la suma siguiente:
            100 + 98 + 96 + 94 + . . . + 0 en este orden
            */

            double  Num1, suma, result;
            Console.WriteLine("Digité el número que desea sumar (tenga en cuenta que si digita un número par los sumandos seran pares y viciversa)");
            Num1 = double.Parse(Console.ReadLine());
            suma = Num1;
            do
            {
                Num1 = Num1 - 2;
                suma = suma + Num1;
                
                Console.WriteLine(Num1);
            } while (Num1 >= 1);
            Console.WriteLine("El resultado de la suma fue: " + suma);
        }
    }
}
