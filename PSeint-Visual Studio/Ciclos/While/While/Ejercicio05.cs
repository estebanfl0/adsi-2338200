using System;
using System.Collections.Generic;
using System.Text;

namespace While
{
    class Ejercicio05
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 5. Obtener el promedio de calificaciones de un grupo de n alumnos */

            double promedio, nota, alumno, contador = 1, suma = 0;

            Console.WriteLine("Digite el número de alumnos de lo cuales desea digitar las notas");
            alumno = double.Parse(Console.ReadLine());
             
            while(contador <= alumno)
            {
                Console.WriteLine("Digite la nota del alumno " + contador);
                nota = double.Parse(Console.ReadLine());
                suma = suma + nota;
                contador++;
            }
            promedio = suma / alumno;
            Console.WriteLine("El promedio de los alumnos es de " + promedio);



        }
    }
}
