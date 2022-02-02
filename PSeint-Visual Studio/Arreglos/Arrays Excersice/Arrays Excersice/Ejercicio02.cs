using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Excersice
{
    class Ejercicio02
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*2. Llenar dos vectores A y B de 10 elementos cada uno, sumar el elemento uno del vector A con el
            elemento uno del vector B y así sucesivamente hasta 10, almacenar el resultado en un vector C, e
            imprimir el vector resultante.*/

            double[] vectorA = new double[4];
            double[] vectorB = new double[4];
            double[] vectorC = new double[4];
            double sumado1, sumado2;

            Console.WriteLine("Digité números en el vector A");

            for (int i = 0; i < vectorA.Length; i++)
            {
                Console.WriteLine("Digité él número " + (i + 1));
                sumado1 = double.Parse(Console.ReadLine());
                vectorA[i] = sumado1;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Ahora digité números en el vector B");
            Console.WriteLine(" . . . . . . . . . . . . . . . . . . . . . . . .");
            for (int i = 0; i < vectorB.Length; i++)
            {
                Console.WriteLine("Digité el número " + (i + 1));
                sumado2 = double.Parse(Console.ReadLine());
                vectorB[i] = sumado2;
            }
            Console.WriteLine("\n");
            for (int i = 0; i < vectorC.Length; i++)
            {
                vectorC[i] = vectorA[i] + vectorB[i];
                Console.WriteLine("El resultado de la suma " + (i + 1) + " es: " + vectorC[i]);
            }
        }
    }
}
