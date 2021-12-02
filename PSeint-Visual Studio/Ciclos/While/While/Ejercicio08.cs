using System;
using System.Collections.Generic;
using System.Text;

namespace While
{
    class Ejercicio08
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*  */

            double Nums, MayorNum = 0, conjunto, contador = 1;

            Console.WriteLine("Digité el número de elementos númericos del conjunto");
            conjunto = double.Parse(Console.ReadLine());

            while (contador <= conjunto)
            {
                Console.WriteLine("Digité el número " + contador);
                Nums = double.Parse(Console.ReadLine());
                if (Nums > MayorNum)
                {
                    MayorNum = Nums;
                }
                contador++;
            }
            Console.WriteLine("El Mayor número es " + MayorNum);
        }
    }
}
