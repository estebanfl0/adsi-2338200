Proceso ejercicio15
	//15. Pedir el lado de un cuadrado, mostrar su área y su perímetro
	
	//Definición de variables.
	definir lad1, lad2, perimetro, area Como Real;
	
	//Proceso 
	Escribir "Digite uno de los lados del cuadrado";
	Leer lad1;
	
	//Proceso 
	lad2 <- lad1;
	perimetro <- (2 * lad1) + (2 * lad2);
	area <- lad1 * lad2;
	
	//Salida
	Escribir "El area del cuadrado es igual a ", area;
	Escribir "El perimetro del cuadrado es igual a ", perimetro;

	
FinProceso
