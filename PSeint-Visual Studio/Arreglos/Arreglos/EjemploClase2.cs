using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    class EjemploClase2
    {
        static void Main(string[] args)
        {
            /*Se requiere almacenar las notas de N estudiantes. Y cual es 
             el promedio del grupo, cual es la nota mas alta, cuantos perdieron la nota, 
            cual es el porcentaje de las personas que ganaron el examen*/

            int cantNotas;
            double nota, suma = 0, promedio, notaAlta = 0, porcentaje = 0;
            int contPerdidas = 0;
            Console.WriteLine("Cuantos notas de estudiantes desea almacenar");
            _ = int.TryParse(Console.ReadLine(), out  cantNotas);
            double[] vectorNotas = new double [cantNotas];

            // Ciclo para llenar las notas del vector
            for (int i=0; i<vectorNotas.Length; i++)
            {
                Console.WriteLine("Digité la nota del estudiante " + (i + 1));
                _ = double.TryParse(Console.ReadLine(), out nota);
                suma += nota;
                vectorNotas[i] = nota;
            }
            
            promedio = suma / vectorNotas.Length;
            for (int i = 0; i < vectorNotas.Length; i++)
            {
                // Cuantos perdieron el examen
                if (vectorNotas[i] < 3)
                {
                    contPerdidas++;
                }
                //Nota mas alta
                if (vectorNotas[i] > notaAlta)
                {
                    notaAlta = vectorNotas[i];
                }
                porcentaje = ((contPerdidas - cantNotas) * 100) / cantNotas;
            }
            Console.WriteLine("El promedio del grupo es: " + promedio);
            Console.WriteLine("La nota mas alta fue: " + notaAlta);
            Console.WriteLine(contPerdidas + " Perdieron la nota");
            Console.WriteLine("El porcentaje de personas que ganaron el examen fue: " + porcentaje + "%");

        }
    }
}
