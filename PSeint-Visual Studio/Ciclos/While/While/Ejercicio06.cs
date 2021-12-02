using System;
using System.Collections.Generic;
using System.Text;

namespace While
{
    class Ejercicio06
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 6. Calcular el promedio de edades de hombres, mujeres y de todo un grupo de n alumnos. */

            double donna = 0, uomo = 0, edad, sexo, contador = 1, suma = 0, promedioM =0, promedio=0, alumno, conteo =0;

            Console.WriteLine("Digite el número de alumnos del grupo");
            alumno = double.Parse(Console.ReadLine());

            while (contador <= alumno)
            {
                Console.WriteLine("El alumno " + contador + " es: 1. Mujer 2. Hombre");
                sexo = double.Parse(Console.ReadLine());
                while (sexo !=  1 && sexo != 2)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("El alumno es: 1. Mujer 2. Hombre");
                    sexo = double.Parse(Console.ReadLine());
                }
                if (sexo == 1)
                {
                    donna++;
                    Console.WriteLine("¿Cuantos años tiene la mujer?");
                    edad = double.Parse(Console.ReadLine());
                    conteo += edad;
                    promedioM = conteo / donna ;
                }
                else
                {
                    uomo++;
                    Console.WriteLine("¿Cuantos años tiene el hombre?");
                    edad = double.Parse(Console.ReadLine());
                    conteo += edad;
                    promedio = conteo / uomo;
                }
                contador++;
            }
            Console.WriteLine("El promedio de edad de las mujeres en el grupo es de " + promedioM);
            Console.WriteLine("El promedio de edad de los hombres en el grupo es de " + promedio);


        }
    }
}
