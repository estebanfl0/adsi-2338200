using System;
using System.Collections.Generic;
using System.Text;

namespace For
{
    class Ejercicio3
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*3. Leer 20 números e imprimir cuantos son positivos, cuantos negativos y cuantos cero.*/

            int Nums;
            double NumPos = 0, NumNeg = 0, Ceros = 0;

            Console.WriteLine("Digite números Reales");

            for(int i=1; i<=20; i += 1)
            {
                Console.WriteLine("Número " + i);
                Nums = int.Parse(Console.ReadLine());
                if (Nums > 0)
                {
                    NumPos ++;
                }
                else if (Nums < 0)
                {
                    NumNeg = NumNeg + 1;
                }
                else
                {
                    Ceros = Ceros + 1;
                }
            }
            Console.WriteLine("Números Positivos  " + NumPos);
            Console.WriteLine("Números Negativos  " + NumNeg);
            Console.WriteLine("Ceros  " + Ceros);


        }
    }
}
