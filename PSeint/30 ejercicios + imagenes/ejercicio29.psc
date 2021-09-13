Proceso ejercicio29
	//29. Dado un monto, calcular el descuento considerando que por encima de 100 el descuento es del 10%
	//y por debajo de 100, el descuento es del 2%.
	
	//Determinacion de variables
	Definir descuento, Pcompra Como Real;
	
	Escribir "Escriba el precio tota de su compra";
	Leer Pcompra;
	
	//Proceso 
	Si (Pcompra > 100) Entonces
		descuento <- Pcompra - [(10 * 100) / Pcompra];
		Escribir "Su descuento fue de ", descuento;
	SiNo
		descuento <- Pcompra - [(2 * 100) / Pcompra];
		Escribir "Su descuento fue de ", descuento;
	FinSi
	
FinProceso
