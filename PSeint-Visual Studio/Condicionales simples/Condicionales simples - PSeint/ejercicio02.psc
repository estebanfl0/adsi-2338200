Proceso ejercicio02
	//2. La compañía de seguros de vida atlas se va a cambiar de domicilio y por lo tanto pone en venta su
	//terreno pero no tiene una idea del valor del terreno, entonces solicita al departamento de sistemas
	//que le desarrolle un algoritmo con la finalidad de que calcule e imprima el precio del terreno del cual
	//se tiene los siguientes datos: largo, ancho y precio por metro cuadrado, si el terreno tiene más de
	//400 metros cuadrados se hace un descuento del 10%.
	
	//Declaración de variables
	Definir largo, ancho, valor_metro2, area, total_pagar Como Real;
	
	//Salida
	Escribir "Digite el largo del terreno";
	Leer largo;
	Escribir "Digite el ancho del terreno";
	Leer ancho;
	Escribir "Digite el precio por metro cuadrado del terreno";
	Leer valor_metro2;
	
	//Proceso 
	area <- (largo * ancho);
	total_pagar <- (area * valor_metro2);
	
	
	Si (area > 400) Entonces
		
		total_pagar <- total_pagar - (total_pagar * 10 / 100);
		
	FinSi
	
	Escribir "Su total a pagar es de ", total_pagar;
	
	
FinProceso
