using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio02
    {
        static void MainTemporal(string[] args)
        {
			/*2. Un alumno de la clase de lógica matemática desea desarrollar un algoritmo y diagrama de flujo en el
            cual introduzca un número entero positivo e invierta los dígitos del número. Mostrar el número
            invertido.*/

			int N, OtroNum;
			double Solucion = 0;

			do
			{
				Console.WriteLine("Digite un numero");
				bool resp = int.TryParse(Console.ReadLine(), out N);

				do
				{
					Solucion = Solucion * 10 + N % 10;
					N /= 10; //N = N / 10;
				} while (N > 0);

				Console.WriteLine("El numero invertido es: " + Solucion );

				Console.WriteLine("Ingrese #(1) si desea modificar el numero elegido o ingrese #(2) si quiere finalizar ");
				OtroNum = int.Parse(Console.ReadLine());
			}
			while (OtroNum != 2);
			Console.WriteLine("Finalizado");
		}
    }
}
