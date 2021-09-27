Proceso ejercicio2021
	//20. Pedir dos números y decir cuál es el mayor
	
	//Definición de variables.
	Definir Num1, Num2 Como Real;
	
	//Salida
	Escribir "Digite el primer numero";
	//Entrada
	Leer num1;
	//Salida
	Escribir "Digite el segundo numero";
	//Entrada
	Leer Num2;
	
	//Proceso 
	Si (Num1>Num2) Entonces
		
		Escribir "El mayor es ", num1;
	SiNo
		Si (Num2>num1) Entonces
			
			Escribir "El mayor es ", Num2;
		SiNo
			Escribir "Son iguales ambos numeros";
		FinSi
	FinSi

	
FinProceso
