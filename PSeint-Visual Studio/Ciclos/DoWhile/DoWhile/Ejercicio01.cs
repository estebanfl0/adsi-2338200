using System;

namespace DoWhile
{
    class Ejercicio01
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*1. En un supermercado una ama de casa pone en su carrito los artículos que va tomando de los
            estantes. La señora quiere asegurarse de que el cajero le cobre bien lo que ella ha comprado, por lo
            que cada vez que toma un articulo anota su precio junto con la cantidad de artículos iguales que ha
            tomado y determina cuanto dinero gastara en ese articulo; a esto le suma lo que ira gastando en los
            demás artículos, hasta que decide que ya tomo todo lo que necesitaba. Ayúdale a esta señora a
            obtener el total de sus compras.
            */
            char opcion;
            int suma = 0;
            do
            {
                Console.WriteLine("Ingrese el nombre del articulo");
                string NomArtiulo = Console.ReadLine();
                Console.WriteLine("Ingresé la cantidad del articulo");
                _ = int.TryParse(Console.ReadLine(), out int cantidad);
                Console.WriteLine("Ingresé el valor del articulo");
                _ = int.TryParse(Console.ReadLine(), out int valor);

                int precio_total_Articulo = valor * cantidad;
                Console.WriteLine("El total del articulo " + NomArtiulo + " es: " + precio_total_Articulo);
                suma += precio_total_Articulo; 
                Console.WriteLine("Desea ingresar más articulos");
                _ = char.TryParse(Console.ReadLine(), out opcion);
            } while (opcion == 'S');
            Console.WriteLine("El total a pagar de la compra será " + suma);
        }
    }
}
