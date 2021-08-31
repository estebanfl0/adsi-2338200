Proceso ejercicio12
	//12. Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
	//horas que trabajó. Se debe mostrar el nombre y el pago de la persona.
	
	//Definicion de variables 
	Definir nombre como Cadena;
	Definir horas_trabajadas Como Entero;
	Definir valor_hora, total_pagar Como Real;
	
	//Proceso 
	Escribir "Digite su nombre completo";
	Leer nombre;
	Escribir "Escriba el valor por cada hora de su trabajo";
	Leer valor_hora;
	Escribir "Escriba la cantidad de horas que ha trabajado en este mes";
	Leer horas_trabajadas;
	
	//Proceso 
	total_pagar <- valor_hora * horas_trabajadas;
	
	Escribir "Señor/a ", nombre, " El monto total de su sueldo este mes es de ", total_pagar, " Dolares";
	

	
FinProceso
