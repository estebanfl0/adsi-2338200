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

            /*for (int i=0; i<=10; i+=2)
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

            /*Console.WriteLine("Cuantos números desea ingresar");
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

            double Notica;
            do
            {
                Console.WriteLine("Ingrese el valor de la nota (Entre 0 y 5)");
                _ = double.TryParse(Console.ReadLine(), out Notica);
                if (Notica < 0 || Notica > 5)
                {
                    Console.WriteLine("Nota No valida, vúelva a ingresar la nota");
                }
            } while (Notica < 0 || Notica > 5);*/

            string contraseña;
            int numIntentos = 3;
            do
            {
                Console.WriteLine("Digité su contraseña (intento número " + numIntentos + ")");
                contraseña = Console.ReadLine();
                if (contraseña == "Efg123000")
                {
                    Console.WriteLine("Contraseña Correcta");
                }
                else
                {
                    numIntentos--;
                    if (numIntentos == 0)
                    {
                        Console.WriteLine("Cuenta bloqueada");
                    }
                }

            } while (contraseña != "Efg123000" || numIntentos == 0);
           

            //int opcionOp;
            //double resultado, num1, num2;
           /*do
            {
                Console.WriteLine("Ingrese la operación que desea utilizar");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                opcionOp = int.Parse(Console.ReadLine());
                Console.WriteLine("Digité el primer número");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digité el segundo número");
                num2 = double.Parse(Console.ReadLine());
                switch (opcionOp)
                {
                    case 1:
                        Console.WriteLine("Seleccionó Suma");
                        resultado = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("Seleccionó Resta");
                        resultado = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("Seleccionó Multiplicación");
                        resultado = num1 * num2;
                        Console.WriteLine(num1 + " x " + num2 + " = " + resultado);
                        break;
                    case 4:
                        Console.WriteLine("Seleccionó División");
                        resultado = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + resultado);
                        break;
                    case 5:
                        Console.WriteLine("Seleccionó Salir");
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        break;
                }
            } while (opcionOp != 5);*/



        }
    }
}
