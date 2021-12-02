using System;
using System.Collections.Generic;
using System.Text;

namespace For
{
    class Ejercicio6
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*6. Una persona debe realizar un muestreo con 50 personas para determinar el promedio de peso de los
            niños, jóvenes, adultos y adultos mayores que existen en su zona habitacional. Se determinan las
            categorías con base en la sig, tabla...
             ___________________________________________
            |CATEGORIA          |     EDAD              |
            |Niños              |     0 – 12            |
            |Jóvenes            |     13 - 29           |
            |Adultos            |     30 - 59           |
            |Adultos Mayores    |     60 en adelante    |
            
            Se debe solicitar la edad y el peso de cada persona y calcular y mostrar el promedio por categoría.
            */

            /*  mayor que es > . ... El símbolo de menor que es < */
           
            Console.WriteLine("Peso promedio de los usarios");
            double peso, edad, promedio, suma = 0, niños = 0, jovenes = 0, adultos = 0, AdultoMay = 0;

            for (int i=1; i <= 12; i++)
            {
                Console.WriteLine("Edad de la persona " + i + " (Si es menor de un año colocar cero)");
                edad = double.Parse(Console.ReadLine());
                while (edad < 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("ERROR!!! No se aceptan números negativos para la edad");
                    Console.WriteLine("\n");
                    Console.WriteLine("Edad de la persona " + i + " (Si es menor de un año colocar cero)");
                    edad = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Peso de la persona " + i);
                peso = double.Parse(Console.ReadLine());
                if (edad > -1 || edad <=12)
                {
                    niños++;
                    suma += peso;
                    promedio = suma / niños;
                    Console.WriteLine("El promedio en los niños es " + promedio);
                }
                else if (edad > 12 || edad <= 29)
                {
                    jovenes++;
                    suma += peso;
                    promedio = suma / jovenes;
                    Console.WriteLine("El promedio en los Jovenes es " + promedio);
                }
                else if (edad > 29 || edad <= 59)
                {
                    adultos++;
                    suma += peso;
                    promedio = suma / adultos;
                    Console.WriteLine("El promedio en los adultos es " + promedio);
                }
                else 
                {
                    AdultoMay ++;
                    suma += peso;
                    promedio = suma / AdultoMay;
                    Console.WriteLine("El promedio en los adultos mayores es " + promedio);
                }
            }

        }
    }
}
