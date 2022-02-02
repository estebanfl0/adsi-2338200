using System;

namespace Arreglos
{
    class EjemploClase
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Arreglos/Arrays - Vectores");

            //Declaración/ Definición vector
            int[] numeros;

            //Inicialización
            numeros = new int[5];

            //Asignación Vector
            numeros[2] = 6;
            numeros[4] = 20;

            Console.WriteLine("Número en posición 4: " + numeros[4]);
            Console.WriteLine("Número en posición 0: " + numeros[0]);
            numeros[4] = 35;
            Console.WriteLine("Número en posición 4: " + numeros[4]);
            

            //Recorremos con un ciclo FOR el vector para asignar los datos 
            for (int i = 0; i<numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número para posición " + i);
                int num = int.Parse(Console.ReadLine());
                numeros[i] = num;
            }

            //Recorremos el vector para mostrar los datos
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Valor en la posición " + i + ": " + numeros[i]);
            }
        }
    }
}
