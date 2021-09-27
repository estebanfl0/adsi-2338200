Proceso ejercicio03
	//3. Hacer un algoritmo que declare una variable para guardar el promedio del semestre, otra para guardar
	//el nombre de un estudiante y otra para guardar el número de notas perdidas.
	
	//Definir Variables
	Definir nota01, nota02, nota03, promedio Como Real;
	Definir Nombre_alumno como Cadena;
	Definir Notas_perdidas Como Entero;
	//Proceso 
	Escribir "Digite su nombre";
	Leer Nombre_alumno;
	Escribir "Digite la primera nota";
	Leer nota01;
	Escribir "Digite la segunda nota";
	Leer nota02;
	Escribir "Digite la tercera nota";
	Leer nota03;
	//Proceso 
	Notas_perdidas <- 0;
	promedio <- (nota01 + nota02 + nota03)/3;
	Escribir "Alumno ", Nombre_alumno, " su promedio es ", promedio, " y tiene ", Notas_perdidas, " notas perdidas";
	
	
	
	
FinProceso
