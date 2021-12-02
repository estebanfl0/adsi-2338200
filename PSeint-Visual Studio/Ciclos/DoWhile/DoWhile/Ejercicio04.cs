using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio04
    {
        static void MainTemporal(string[] args)
        {
            /*4. Un censador recopila ciertos datos aplicando encuestas para el último Censo Nacional de Población
            y Vivienda. Desea obtener de todas las personas que alcance a encuestar en un día, que porcentaje
            tiene estudios de primaria, secundaria, carrera técnica, estudios profesionales y estudios de
            posgrado.
            El programa debe preguntar si se desea continuar ingresando datos.
            */
            int nivelAcademic, contador = 1, primaria = 0, secundaria = 0, tecnico = 0, profesional = 0, posgrado = 0, Nada = 0;
            double personas, seguir;
            Console.WriteLine("Ejercicio 04");
            Console.WriteLine("Digité el número de personas que va a encuestar incialmente");
            personas = double.Parse(Console.ReadLine());
            do
            {
                do
                {
                    Console.WriteLine("¿Cual es el nivel de educación del encuestado número " + contador);
                    Console.WriteLine("1. Primaria");
                    Console.WriteLine("2. Secundaria");
                    Console.WriteLine("3. Tecnico");
                    Console.WriteLine("4. Profesional");
                    Console.WriteLine("5. Posgrado");
                    Console.WriteLine("6. Ninguna de las anteriores");
                    nivelAcademic = int.Parse(Console.ReadLine());

                                while(nivelAcademic < 1 || nivelAcademic > 6)
                                {
                                    Console.WriteLine("\n");
                                    Console.WriteLine("ERROR");
                                    Console.WriteLine("¿Cual es el nivel de educación del encuestado número " + contador);
                                    Console.WriteLine("1. Primaria");
                                    Console.WriteLine("2. Secundaria");
                                    Console.WriteLine("3. Tecnico");
                                    Console.WriteLine("4. Profesional");
                                    Console.WriteLine("5. Posgrado");
                                    Console.WriteLine("6. Ninguna de las anteriores");
                                    nivelAcademic = int.Parse(Console.ReadLine());
                                }

                    if (nivelAcademic == 1)
                    {
                        primaria++;
                    }else if(nivelAcademic == 2)
                    {
                        secundaria++;
                    }else if(nivelAcademic == 3)
                    {
                        tecnico++;
                    }else if (nivelAcademic == 4)
                    {
                        profesional++;
                    }else if (nivelAcademic == 5)
                    {
                        posgrado++;
                    }
                    else
                    {
                        Nada++;
                    }
                    contador ++;
                } while (contador <= personas);
                Console.WriteLine("¿Desea Ingresar más datos?");
                Console.WriteLine("1. SI ");
                Console.WriteLine("Cualquier otro número. NO ");
                seguir = int.Parse(Console.ReadLine());
            } while (seguir == 1);
            Console.WriteLine("Personas que no tienen estudios: " + Nada);
            Console.WriteLine("Personas estudios primarios: " + primaria);
            Console.WriteLine("Personas estudios secundarios: " + secundaria);
            Console.WriteLine("Personas estudios tecnicos: " + tecnico);
            Console.WriteLine("Personas estudios profesionales: " + profesional);
            Console.WriteLine("Personas estudios de posgrado: " + posgrado);
        }
    }
}
