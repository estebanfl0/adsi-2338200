using System;
using System.Collections.Generic;
using System.Text;

namespace For
{
	class Ejercicio8
	{
		static void Main(string[] args)
		{


			/*8. Un alumno de la clase de lógica matemática desea desarrollar un programa que calcule el factorial
			de un número N, el cual le dará al usuario, el factorial de un número N, definido matemáticamente
			como N! se obtiene como la multiplicación de todos los números que están desde el 1 hasta el N = 1
			* 2 * 3 * ..... (N-2) * (N-1) * N, como se muestra en la figura, por definición el factorial de 0 es 1.*/

			int N, Factorial = 1;

			Console.WriteLine("Digite el número que desea calcular el factorial");
			N = int.Parse(Console.ReadLine());

			while (N < 0)
            {
				Console.WriteLine("ERROR [El número es negativo]");
				Console.WriteLine("Digite el número que desea calcular el factorial");
				N = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("\n");
			for (int i=N; i>=1; i--)
            {
				Console.WriteLine(i);
				Factorial = Factorial * i; 
            }
			if (N == 0)
            {
				Factorial = 1;
            }
			Console.WriteLine("El factorial del número " + N + " es " + Factorial);

		}
	}

		
}
	
