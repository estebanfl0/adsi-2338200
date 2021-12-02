using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio08
    {
        static void MainTemporal(string[] args)
        {
            /*8. Hacer un programa que lea caracteres desde teclado y vaya contando las vocales que aparecen. El
            programa terminará cuando lea el carácter # y entonces mostrará un mensaje indicando cuántas
            vocales ha leído (cuántas de cada una de ellas).
            */

            int Vocales = 0, A = 0, E = 0, I = 0, O = 0, U = 0;
            string caracter;
            do
            {
                Console.WriteLine("Digite cualquier caracter");
                caracter = Console.ReadLine();
                caracter.ToUpper();
                if (caracter == "A" || caracter == "E" || caracter == "I" || caracter == "O" || caracter == "U")
                {
                    A++;
                }else if(caracter == "E")
                {
                    E++;
                }else if(caracter == "I")
                {
                    I++;
                }else if(caracter == "O")
                {
                    O++;
                }else if (caracter == "U")
                {
                    U++;
                }else
                {
                    Console.WriteLine("No Hay Vocales");
                }
            } while (caracter != "#");
            Vocales = A + E + I + O + U;
            Console.WriteLine("Se registraron " + Vocales + " Vocales");
            Console.WriteLine(A + "... A");
            Console.WriteLine(E + "... E");
            Console.WriteLine(I + "... I");
            Console.WriteLine(O + "... O");
            Console.WriteLine(U + "... U");
        }
    }
}
