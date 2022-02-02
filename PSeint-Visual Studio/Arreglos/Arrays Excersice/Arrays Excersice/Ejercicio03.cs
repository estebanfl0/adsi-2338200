using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Excersice
{
    class Ejercicio03
    {
        static void MainTemporal(string[] args)
        {
            /*3. Almacenar 15 números en un vector, imprimir cuantos son ceros, cuántos son negativos, cuantos
            positivos. Imprimir además la suma de los negativos, la suma de los ceros y la suma de los positivos.*/

            double NumPositivo = 0, Posit = 0, NumNegativo = 0,  Negat = 0, NumCero = 0, Ceros = 0, Num;
            
            double[] VectorA = new double[15];
            Console.WriteLine("Digité numeros para el vector A");
            for (int i = 0; i < VectorA.Length; i++)
            {
                Console.WriteLine("Número " + (i + 1)); 
                Num = double.Parse(Console.ReadLine());

                if (Num == 0)
                {
                    NumCero++;
                    Ceros = Ceros + Num;
                } else if (Num > 0)
                {
                    NumPositivo++;
                    Posit = Posit + Num;
                } else
                {
                    NumNegativo++;
                    Negat = Negat + Num;
                }


            }

            Console.WriteLine("La cantidad de Ceros fue = " + NumCero);
            Console.WriteLine("La suma de los ceros fue = " + Ceros);
            Console.WriteLine("La cantidad de Numeros Positivos fue = " + NumPositivo);
            Console.WriteLine("La suma de los Numeros Positivos fue = " + Posit);
            Console.WriteLine("La cantidad de Numeros Negativos fue = " + NumNegativo);
            Console.WriteLine("La suma de los Numeros negativos fue = " + Negat);
        }
    }
}
