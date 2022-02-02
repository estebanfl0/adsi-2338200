using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    class Booleanos
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("¿Cuantos años tiene?");

            bool validacion = int.TryParse(Console.ReadLine(), out int edad);

            if (validacion /* == true */)
            {
                Console.WriteLine("Digitó correctamente su edad");
            } else
            {
                Console.WriteLine("No digitó un valor correcto");
            }
        }

    }
}
