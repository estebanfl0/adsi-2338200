Proceso ejercicio19
	//19. Pedir dos números y decir si uno es múltiplo del otro
	
	//definir variables 
	Definir num1, num2 como real;
	
	//Salida
	Escribir "Digite el primer numero";
	//Entrada
	Leer num1;
	//Salida
	Escribir "Digite el segundo numero";
	//Entrada 
	Leer num2;
	
	//Proceso 
	Si (num1%num2=0) o (num2%num1=0) Entonces
		Escribir "Los numeros son multiplos";
	SiNo
		Escribir "Los numeros no son multiplos";
	FinSi

	
FinProceso
