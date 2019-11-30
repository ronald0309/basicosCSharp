using System;

public class Calculadora
{
        private double ultimoResultado;
        double resultadoSuma;
    decimal resultadoResta;
    public double Sumar(double primerValor, double segundoValor)
        {
        primerValor += segundoValor;
        resultadoSuma += primerValor;
        return resultadoSuma;
        }   
        public decimal Dividir(decimal primerValor, decimal segundoValor)
        {
            
             resultadoResta = primerValor / segundoValor;
            return resultadoResta;
        }
    
    public Calculadora()
	{

	}
}
