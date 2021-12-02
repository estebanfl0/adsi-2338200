using System;
using System.Collections.Generic;
using System.Text;

namespace For
{
    class Ejercicio5
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*5. Calcular e imprimir la tabla de multiplicar de un número cualquiera. Imprimir el multiplicando, el
            multiplicador y el producto.*/

            /*  mayor que es >. ... El símbolo de menor que es < */
            double N, resultado = 0;

            Console.WriteLine("Digite cualquier número y el programa le mostrará las tablas de este número (1-10)");
            N = double.Parse(Console.ReadLine());
            Console.WriteLine("Tablas de Multiplicar");

            for (int i=1; i <= 10; i++)
            {
                resultado = N * i;
                Console.WriteLine(N + " x " + i + " = " + resultado);
            }
        }
    }
}
