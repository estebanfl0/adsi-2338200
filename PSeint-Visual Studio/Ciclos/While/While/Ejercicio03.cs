﻿using System;
using System.Collections.Generic;
using System.Text;

namespace While
{
    class Ejercicio03
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 3. Determinar cuantos hombres y cuantas mujeres se encuentran en un grupo de n personas,
            suponiendo que los datos son extraídos alumno por alumno.
             */

            double hombres = 0, mujeres = 0, alumnos, sexo;
            string nombre;
            Console.WriteLine("DIgite el numero total de alumnos");
            alumnos = double.Parse(Console.ReadLine());

            for (int i = 1; i <= alumnos; i++)
            {
                Console.WriteLine("Nombre del alumno " + i);
                nombre = Console.ReadLine();
                Console.WriteLine("Sexo del alumno ");
                Console.WriteLine("1. Hombre");
                Console.WriteLine("2. Mujer");
                sexo = double.Parse(Console.ReadLine());

                while (sexo < 1 || sexo > 2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("ERROR");
                    Console.WriteLine("Sexo del alumno ");
                    Console.WriteLine("1. Hombre");
                    Console.WriteLine("2. Mujer");
                    sexo = double.Parse(Console.ReadLine());
                }
                if (sexo == 1)
                {
                    hombres = hombres + 1;
                }
                else
                {
                    mujeres = mujeres + 1;
                }
            }

            Console.WriteLine("Hay " + hombres + " Hombres");
            Console.WriteLine("Hay " + mujeres + " Mujeres");

        }

    }
}
