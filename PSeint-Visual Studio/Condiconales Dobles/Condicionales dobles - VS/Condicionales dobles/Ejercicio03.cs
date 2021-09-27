using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_dobles
{
    class Ejercicio03
    {
        static void MainTemporal(string[] args)
        {
            /*3. Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o mas se
            aplica un descuento del 20% sobre el total de la compra y si son menos de tres camisas un descuento del 10%*/

            double descuento, precioU, total_pagar;
            byte Cantidad;

            Console.WriteLine("Digite el valor unitario de las camisas");
            precioU = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad d ecamisas que desea comprar");
            Cantidad = byte.Parse(Console.ReadLine());

            total_pagar = (Cantidad * precioU);

            if (Cantidad >= 3)
            {
                descuento = total_pagar - (total_pagar * 20 / (100)); 
            }
            else
            {
                descuento = total_pagar - (total_pagar * 10 / (100));
            }

            Console.WriteLine("Su total a pagar es de " + total_pagar);
            Console.WriteLine("Menos el descuento, debe pagar " + descuento);



        }

    }
}
