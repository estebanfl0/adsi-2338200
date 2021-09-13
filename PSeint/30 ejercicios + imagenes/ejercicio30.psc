Proceso ejercicio30
	//30. Leer dos números y calcular su división, teniendo en cuenta que el denominador no debe ser 0 (cero)
	
	//Definir variables 
	Definir Num1, Num2, resultado Como Real;
	
	//Salida
	Escribir "Digite el primer numero, teniendo en cuenta que no puede ser cero (0)";
	//Entrada 
	Leer Num1;
	//Salida 
	Escribir "Digite el segundo numero teniendo en cuenta que no pueda ser cero (0)";
	//Entrada
	Leer Num2;
	
	//Proceso 
	Si (Num1==0) o (Num2==0) Entonces
		Escribir "Syntax error";
	SiNo
		Resultado <- Num1/Num2;
		Escribir "El resultado es ", Resultado;
	FinSi
	
FinProceso
