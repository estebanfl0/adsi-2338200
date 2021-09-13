Proceso ejercicio24
	//24. Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene
	
	//Definicion de variables 
	definir N como entero;
	
	//Salida
	Escribir "Digite un numero entre 0 y 9999";
	//Entrada
	Leer N;
	
	Si (N <= 9) y (N > 0) Entonces
		Escribir "El numero tiene una (1) cifra";
	SiNo
		Si (N > 9) y (N <= 99) Entonces
			Escribir "El numero tiene dos (2) cifras";
		SiNo
			Si (N > 99) y (N <= 999) Entonces
				
				Escribir "El numero tiene tres (3) cifras";
			SiNo
				Si (N > 999) y (N <= 9999) Entonces
					Escribir "El numero tiene cuatro (4) cifras ";
					
				FinSi
			FinSi
		FinSi
	FinSi
	
FinProceso
