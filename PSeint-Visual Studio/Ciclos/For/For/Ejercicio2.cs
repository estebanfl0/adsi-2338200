﻿using System;
using System.Collections.Generic;
using System.Text;

namespace For
{
    class Ejercicio2
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*2. Leer 10 números e imprimir solamente los números positivos*/

            int Nums;
            Console.WriteLine("Digite numeros reales");
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine("Número " + i);
                Nums = int.Parse(Console.ReadLine());

                if (Nums > 0)
                {
                    Console.WriteLine("El número " + Nums + " es positivo");
                }
            }




        }
    }
}
