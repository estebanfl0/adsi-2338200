Proceso ejercicio28
//28. Un trabajador recibe su pago, según la cantidad de horas trabajadas y su valor. Si la cantidad de
//horas trabajadas es mayor que 40, éstas se consideran horas extra, y tienen un incremento de $10000
//(diez mil) sobre el valor de la hora. Calcular y mostrar el salario (pago) del trabajador. Nota: leer horas
//trabajadas y valor de la hora.
	
	//Definición de variables
	Definir Horas_trabajadas Como Entero;
	Definir Nombre_trabajador como cadena;
	Definir Valor_hora, total_pagar, horas_extras Como Real;
	
	
	//Salida 
	Escribir "Escriba su nombre completo";
	//Entrada 
	Leer Nombre_trabajador;
	//Salida 
	Escribir "Escriba el numero de horas que trabajo esta semana";
	//Entrada 
	Leer Horas_trabajadas;
	//Salida 
	Escribir "Indique el valor por cada hora de su trabajo";
	//Entrada
	Leer Valor_hora;
	
	//Proceso 
	Si (Horas_trabajadas > 40) Entonces
		total_pagar <- 40 * Valor_hora;
		horas_extras <- (Valor_hora + 10000) * (Horas_trabajadas - 40);
		Escribir "Su salario semanal fue de ", total_pagar, " incluido el pago de horas extra";
	SiNo 
		total_pagar <- (Valor_hora * Horas_trabajadas);
		Escribir "Su salario semanal fue de ", total_pagar, " mas la horas extra en total es ", horas_extras;
	FinSi
FinProceso
