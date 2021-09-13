Proceso ejercicio26
	//26. Pedir una nota numérica entera entre 0 y 10, y mostrar dicha nota de la forma: cero, uno, dos, tres...
	
	//Definicion de variables 
	Definir NN Como Entero;
	
	//Salida
	Escribir "Digite una nota numerica entera entre 1 y 10";
	//Entrada 
	Leer NN;
	
	//Proceso 
	Si (NN == 0) Entonces
		Escribir "Cero";
	SiNo
		Si (NN == 1) Entonces
			Escribir "Uno";
		SiNo
			Si (NN == 2) Entonces
				Escribir  "Dos";
			SiNo
				Si (NN == 3) Entonces
					Escribir "Tres"; 
				SiNo
					Si (NN == 4) Entonces
						Escribir "Cuatro";
					SiNo
						Si (NN == 5) Entonces
							Escribir "Cinco";
						SiNo
							Si (NN == 6) Entonces
								Escribir "Seis";
							SiNo
								Si (NN == 7) Entonces
									Escribir "Siete";
								SiNo
									Si (NN == 8) Entonces
										Escribir "Ocho";
									SiNo
										Si (NN == 9) Entonces
											Escribir "Nueve";
										SiNo
											Si (NN == 10) Entonces
												Escribir "Diez";
											SiNo
												Escribir "No se encontraron datos";
											FinSi
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi

	
FinProceso
