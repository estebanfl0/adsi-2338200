using System;

namespace Ciclos_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*for (int i=1; i<=10; i++)
            {
                //Codigo que se requiere repetir
                Console.WriteLine("i: " + i);
            }*/

            for (int i=0; i<=10; i+=2)
            {
                Console.WriteLine("i: " + i);
            }

            //Sumar 10 numeros ingresados por el usuario
            double suma = 0;
            int cantNumeros;
            Console.WriteLine("Digite cuantos números desea ingresar");
            cantNumeros = int.Parse(Console.ReadLine());
            for (int i=1; i<=cantNumeros; i++)
            {
                Console.WriteLine("Digite el número " + i);
                _ = int.TryParse(Console.ReadLine(), out int num);
                suma += num; //Acumulador 
                suma = suma + num;
            }


            Console.WriteLine("La suma de todos los numeros es " + suma);


            //Solicitar el salario de n empleados y decir cuanto tiene que pagar
            //cada uno por salud y pension sabiendo que para salud el empleado 
            //debe cubrir el 4% y para pension el 6%

            int NumEmpleados;
            Console.WriteLine("Digite la cantidad de empleados");
            NumEmpleados = int.Parse(Console.ReadLine());
            double pension, salud, salario;

           
            for (int i=1; i<=NumEmpleados; i++) 
            {
                
                Console.WriteLine("Empleado "+i);
                Console.WriteLine("Salario: ");
                salario = double.Parse(Console.ReadLine());
                pension = (salario * 6) / 100;
                salud = (salario * 4) / 100;
                Console.WriteLine("Total pagar pensión: " + pension);
                Console.WriteLine("Total pagar Salud: " + salud);

            }

            string opcion = "Si";
            //double suma = 0;

            while(opcion == "Si") 
            {
                Console.WriteLine("Digite el número que desea sumar");
                _ = double.TryParse(Console.ReadLine(), out double num);
                suma += num;
                Console.WriteLine("Desea ingresar otro número (Si) (No)");
                opcion = Console.ReadLine();
                
            }
            Console.WriteLine("La suma es: " + suma);

            /* Desarrollar un algoritmo que lea n números positivos, determine y muestre
             el promedio de los n números positivos*/

            Console.WriteLine("Cuantos números desea ingresar");
            _ = int.TryParse(Console.ReadLine(), out int n);
            int contador = 0, cantPositivos =0;
            double promedio;
            while (contador < n)
            {
                Console.WriteLine("Ingrese un número ");
                _ = int.TryParse(Console.ReadLine(), out int numero);
                if(numero > 0)
                {
                    suma += numero; //Acumulador
                    cantPositivos++; // Contador
                }
                contador++;
            }
            promedio = (double)suma / (double)cantPositivos;
            Console.WriteLine("El promedio es: " + Math.Round(promedio));
  

        }
    }
}
