using System;
using System.Collections.Generic;
using System.Text;

namespace For
{
    class Ejercicio4
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*4. Suponga que se tiene un conjunto de calificaciones de un grupo de 40 alumnos. Realizar un algoritmo
            para calcular la calificación promedio y la calificación más baja de todo el grupo.*/

            double Calificación, MenorCal = 100, suma = 0, promedio;

            Console.WriteLine("Digite el conjunto de calificación de los 40 alumnos");

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Caficación número " + i);
                Calificación = double.Parse(Console.ReadLine());
                suma = suma + Calificación;

                if (Calificación < MenorCal)
                {
                    MenorCal = Calificación;
                }
            }

            promedio = (suma / 4);
            Console.WriteLine(promedio);
            Console.WriteLine("El promedio de los alumnos es " + promedio);
            Console.WriteLine("La Calificación más baja fue de " + MenorCal);

        }
    }
}
