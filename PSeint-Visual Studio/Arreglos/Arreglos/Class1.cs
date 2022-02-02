using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    class Class1
    {
        static void MainTemporal(string[] args)
        {
            //Solicitar al usuario los nombres de N personas, almacernarlas en un vetor
            // mostrar los nombres almacenados y decir si en la lista de personas
            // se encuentra "ANA"

            string[] nombres;
            int cantName;
            string buscar, name;
            bool Verficación = false;
            Console.WriteLine("Digite la cantidad de nombres que desea ingresar");
            cantName = int.Parse(Console.ReadLine());
            nombres = new string[cantName];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona " + i);
                name = Console.ReadLine();
                nombres[i] = name;
            }

            //Recorremos el vector para mostrar los datos
            for (int i = 0; i < cantName; i++)
            {
                Console.WriteLine("El nombre número " + i + ": " + nombres[i]);
            }
            Console.WriteLine("¿Que nombre desea buscar?");
            buscar = Console.ReadLine();
            for (int i = 0; i < cantName; i++)
            {
                if (nombres[i].ToLower() == buscar.ToLower())
                {
                    Console.WriteLine("Encontré el nombre en la posición " + i);
                    Verficación = true;
                }
            }
            if (Verficación == false)
            {
                Console.WriteLine("NO se encontró el nombre");
            }
        }
    }
}
