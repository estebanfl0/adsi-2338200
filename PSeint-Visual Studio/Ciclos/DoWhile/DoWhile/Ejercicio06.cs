using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio06
    {
        static void MainTemporal(string[] args)
        {
            /*6. Leer por cada alumno de Diseño estructurado de algoritmos su número de control y su calificación en
            cada una de las 5 unidades de la materia. Al final que escriba el número de control del alumno que
            obtuvo mayor promedio. Suponga que los alumnos tienen diferentes promedios.*/

            double promedio = 0, calificaciones, notaAcum = 0, MayorProm = 0, contador1 = 1, contador2 = 1, alumnos;

            Console.WriteLine("Digite el número de estudiantes");
            alumnos = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Alumno " + contador1);
                do
                {
                    Console.WriteLine("Digite la nota " + contador2);
                    calificaciones = double.Parse(Console.ReadLine());

                    notaAcum += calificaciones;
                    contador2++;
                } while (contador2 < 6);
                promedio = notaAcum / 5;
                contador2 -= 5;
                notaAcum = 5 * 0;
                if ( promedio > MayorProm)
                {
                    MayorProm = promedio;
                }
                Console.WriteLine("Alumno " + contador1 + " su promedio es " + promedio);
                contador1++;
            } while (contador1 <= alumnos);
            Console.WriteLine("El Mayor Promedio fue: " + MayorProm);
        }
    }
}
