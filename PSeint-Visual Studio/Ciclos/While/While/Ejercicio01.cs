﻿using System;

namespace While
{
    class Ejercicio01
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 1. Una compañía de seguros tiene contratados a n vendedores. Cada uno hace tres ventas a la semana.
            Su política de pagos es que un vendedor recibe un sueldo base, y un 10% extra por comisiones de
            sus ventas. El gerente de su compañía desea saber cuanto dinero obtendrá en la semana cada
            vendedor por concepto de comisiones por las tres ventas realizadas, y cuanto tomando en cuenta su
            sueldo base y sus comisiones */

            string empleado;
            double sueldo, ventas, comisionPorVen, totalpagar, NumEmpleados;

            Console.WriteLine("Compañia de seguros FlowersCorp");

            Console.WriteLine("Digite el numero de empledos");
            NumEmpleados = double.Parse(Console.ReadLine());

            for (int i = 1; i <= NumEmpleados; i++)
            {
                Console.WriteLine("Nombre del empleado " + i);
                empleado = Console.ReadLine();
                Console.WriteLine("Salario del empleado " + i);
                sueldo = double.Parse(Console.ReadLine());
                
                while (sueldo < 0)
                {
                    Console.WriteLine("No es empleado de FlowersCorp");
                }
                Console.WriteLine("Digite el valor total de las 12 ventas de este mes");
                ventas = double.Parse(Console.ReadLine());
                comisionPorVen = (ventas * 10) / 100;
                totalpagar = (comisionPorVen + sueldo);
                Console.WriteLine("Empleado(a) " + empleado);
                Console.WriteLine("Tuvo un sueldo neto de " + sueldo);
                Console.WriteLine("Vendió " + ventas + " en producots o srvicios");
                Console.WriteLine("Tuvo unas comisiones de " + comisionPorVen);
                Console.WriteLine("Para un total a pagar de " + totalpagar);
            }
        }
    }
}
