using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_Anidadas
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            /*3. En una fábrica de computadoras se planea ofrecer a los clientes un descuento que dependerá del número de
            computadoras que compre. Si las computadoras son menos de cinco se les dará un 10% de descuento sobre el
            total de la compra; si el número de computadoras es mayor o igual a cinco pero menos de diez se le otorga un
            20% de descuento; y si son 10 o más se les da un 40% de descuento. El precio de cada computadora es de
            $1 100 000*/

            double PreComput, Descuento, TotPag;
            byte CanComp;

            

            Console.WriteLine(" Welcome User");
            Console.WriteLine("<------------->");
            Console.WriteLine("¿Cuantos computadores desea comprar?");
            CanComp = byte.Parse(Console.ReadLine());
            
            PreComput = (500000 + 600000);
            

            if (CanComp < 5)
            {
                
                Descuento = 
            }
            TotPag = (CanComp * PreComput) - Descuento;

            Console.WriteLine("");

        }
    }
}
