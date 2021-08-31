Proceso ejercicio06
	//6. Hacer un algoritmo que lea el nombre de un artículo, el valor unitario, la cantidad a comprar y muestre
	//el nombre y el total a pagar.
	definir valor_unitario, total_pagar Como Real;
	Definir nombre_articulo como cadena;
	definir cantidad_articulos Como Entero;
	
	//Proceso 
	Escribir "Escriba el nombre del articulo";
	Leer nombre_articulo;
	Escribir "Escriba el valor del articulo";
	Leer valor_unitario;
	Escribir "Escriba la cantidad que quiere llevar de este articulo";
	Leer cantidad_articulos;
	
	//Proceso
	total_pagar <- valor_unitario * cantidad_articulos;
	
	//Salida
	Escribir "El total a pagar es ", total_pagar, " y su compra incluye ", cantidad_articulos, " frascos ", nombre_articulo;
	
FinProceso
