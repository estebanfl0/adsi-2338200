using System;
using System.Collections.Generic;
using System.Text;

namespace While
{
    class Ejercicio07
    {
        static void MainTemporl(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 7. Encontrar el menor valor de un conjunto de n números dados. */

            double Nums, MenorNum = 1000, conjunto, contador = 1;

            Console.WriteLine("Digité el número de elementos númericos del conjunto");
            conjunto = double.Parse(Console.ReadLine());

            while (contador <= conjunto)
            {
                Console.WriteLine("Digité el número " + contador);
                Nums = double.Parse(Console.ReadLine());
                if (Nums < MenorNum)
                {
                    MenorNum = Nums;
                }
                contador++;
            }
            Console.WriteLine("El menor número es " + MenorNum);
        }
    }
}
