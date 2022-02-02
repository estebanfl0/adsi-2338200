using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Excersice
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            /*4. Almacenar 8 números en un vector, almacenarlos en otro vector en orden inverso al vector original
            e imprimir el vector resultante*/

            double Num, NumReverse = 8;

            double[] VectorA = new double[8];
            double[] VectorB = new double[8];

            Console.WriteLine("Asgnelé Números al Vector A");
            for (int i = 0; i < VectorA.Length; i++)
            {
                Console.WriteLine("Número " + (i + 1));
                Num = double.Parse(Console.ReadLine());
                VectorA[i] = Num;
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("Y los números en reversa son . . . . . . . . . . . .");
            Console.WriteLine("\n");
            for (int i = 0; i <= VectorB.Length; i++)
            {
                VectorB[i] = VectorA[i];

                Console.WriteLine("Número " + (i + 1));
                Console.WriteLine(VectorB[i]);
            }
        }
    }
}
