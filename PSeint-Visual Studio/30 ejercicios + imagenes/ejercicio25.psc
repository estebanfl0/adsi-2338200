Proceso ejercicio25
	//25. Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0-2,9), Suficiente (3-4,5) y Bien (4,6-5)
	
	//Definición de variables 
	Definir N Como Real;
	
	//Salida 
	Escribir "Digite una nota o el promedio de sus notas";
	//Entrada 
	Leer N;
	//Proceso 
	Si (N>=0) y (N<=2.9) Entonces
		Escribir "La nota digitada se registra como una nota insuficiente";
	SiNo
		Si (N>2.9) y (N<4.6) Entonces
			Escribir "La nota digitada se registra como una nota suficiente";
		SiNo 
			Si (N >= 4.6) y (N <= 5) Entonces
				Escribir "La nota digitada se registra como una nota Excelente";
			FinSi
		FinSi
		
	FinSi
FinProceso
