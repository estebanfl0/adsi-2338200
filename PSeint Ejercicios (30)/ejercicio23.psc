Proceso ejercicio23
	//23. Pedir tres números y mostrarlos ordenados de mayor a menor.
	
	//Definir variables
	Definir num1, num2, num3 Como Real;
	
	//Salida 
	Escribir "Digite el primer numero";
	//Entrada
	Leer num1;
	//Salida
	Escribir "Digite el segundo numero"; 
	//Entrada
	Leer num2;
	//Salida
	Escribir "Digite el tercer numero";
	//Entrada
	Leer num3;
	
	//Proceso 
	Si (num1 > num2) y ( num2 > num3) Entonces
		Escribir num1;
		Escribir num2;
		Escribir num3;
	SiNo
		Si (num2>num3) y (num3 >num1) Entonces
			Escribir num2;
			Escribir num3;
			Escribir num1;
		SiNo
			Si (num3>num1) y (num1>num2) Entonces
				Escribir num3;
				Escribir num1;
				Escribir num2;
			SiNo
				si	(num3>num2) y (num2>num1) Entonces
					Escribir num3;
					Escribir num2;
					Escribir num1;
				SiNo
					Si (num2 > num1) y (num1 >num3) Entonces
						Escribir num2;
						Escribir num1;
						Escribir num3;
					SiNo
						Si (num1 > num3) y (num3 > num2) Entonces
							Escribir num1;
							Escribir num3;
							Escribir num2;
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi

	
FinProceso
