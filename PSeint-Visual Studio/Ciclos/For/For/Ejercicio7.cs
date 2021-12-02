using System;
using System.Collections.Generic;
using System.Text;

namespace For
{
    class Ejercicio7
    {
        static void MainTemporal(string[] args)
        {
           
            /*7. Al cerrar un expendio de naranjas, 15 clientes recibirán un 15% de descuento si compran más de 10
            kilos. Determinar cuánto pagará cada cliente y cuanto percibirá la tienda por esas compras.*/
            /*  mayor que es > . ... El símbolo de menor que es < */

            double kilo = 10, redondeoInterno = 0;

            double Naranjas, descuento, totalpagar, totalNeto; 

            for (int i=1; i <= 15; i++)
            {
                Console.WriteLine("Bienvenid@ Cliente número " + i);
                Console.WriteLine("Cuantos kilos de naranja compró (Son minimo 10) el cliente " + i);
                Naranjas = double.Parse(Console.ReadLine());
                totalNeto = kilo * Naranjas;
                descuento = (totalNeto * 15) / 100;
                totalpagar = totalNeto - descuento;
                Console.WriteLine("El total a pagar por las naranjas es de " + totalpagar);
                redondeoInterno += totalpagar;
            }

            Console.WriteLine("Ls ventas totales fueron de " + redondeoInterno);

        }
    }
}
