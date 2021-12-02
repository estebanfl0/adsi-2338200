using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio03
    {
        static void MainTemporal(string[] args)
        {
            /*3. En la Cámara de Diputados se levanta una encuesta con todos los integrantes con el fin de determinar
            que porcentaje de los n diputados esta a favor del Tratado de Libre Comercio, que porcentaje esta en
            contra y que porcentaje se abstiene de opinar.
            El programa debe preguntar si se desea continuar ingresando datos*/

            double  Num, contador = 1, voto;
            int favor = 0, contra = 0, No_Opina = 0, seguir;

            Console.WriteLine("Digité el número de diputados que van a votar");
            Num = double.Parse(Console.ReadLine());
            do
            {
                do
                {
                    Console.WriteLine("Diputado número " + contador);
                    Console.WriteLine("1. Para votar a favor. ");
                    Console.WriteLine("2. Para votar en contra. ");
                    Console.WriteLine("3. No sabe. No responde. ");
                    voto = double.Parse(Console.ReadLine());
                    while (voto < 1 || voto > 3)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("[Opción Incorrecta]");
                        Console.WriteLine("Diputado número " + contador);
                        Console.WriteLine("1. Para votar a favor. ");
                        Console.WriteLine("2. Para votar en contra. ");
                        Console.WriteLine("3. No sabe. No responde. ");
                        voto = double.Parse(Console.ReadLine());
                    }
                    if (voto == 1)
                    {
                        favor++;
                    }
                    else if (voto == 2)
                    {
                        contra++;
                    }
                    else
                    {
                        No_Opina++;
                    }

                    contador++;
                } while (contador <=  Num);
                Console.WriteLine("¿Desea Ingresar más datos?");
                Console.WriteLine("1. SI ");
                Console.WriteLine("Cualquier otro número. NO ");
                seguir = int.Parse(Console.ReadLine());
            } while (seguir == 1);
            Console.WriteLine("Votos a favor del tratado de Libre comercio: " + favor);
            Console.WriteLine("Votos en contra del tratado de Libre comercio: " + contra);
            Console.WriteLine("Diputados que no opinaron: " + No_Opina);
        }
    }
}
