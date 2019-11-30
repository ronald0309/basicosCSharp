using System;

namespace basicosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int annoActual = Convert.ToInt32("2019");
            double numeroPI = 3.141592;
            Console.WriteLine("Valores:{0}--{1}", annoActual, numeroPI);
            Decimal montoFactura = 94593.34m + 0.07m;
            float impuestoDeVenta = 9239.04f;
            Console.WriteLine("Valores: {0}--{1}", montoFactura, impuestoDeVenta);
            char letrainicial = 'P';
            string nombreCurso = letrainicial + "rogramacion ll";
            Console.WriteLine("ESte es el curso {0}", nombreCurso);
            bool boolVerdadero = true;
            bool boolFalso = false;
            Console.WriteLine("Variables boleanas:{0} y {1}", boolVerdadero, boolFalso);

            double resultadoSuma = 540 + -18.5; 
            float resultadoResta = 3458.35f - 334.34f;
            decimal resultadoMultiplicacion = 23.423m * 3423m;
            decimal resultadoDivision = 239.42m / 0.3m;
            decimal resultadoResiduo = 2321.423m % 23m;
            double resultadoPotencia = Math.Pow(78, 2);
            double resultadoRaiz = Math.Sqrt(144);
            Console.WriteLine("Resultados: Potencia:{0}, Raiz:{1}, Recidio: {2}, Divicion:{3}, Multiplicacion:{4}, Resta: {5},Suma:{6}", resultadoPotencia, resultadoRaiz, resultadoResiduo, resultadoDivision, resultadoMultiplicacion, resultadoResta, resultadoSuma);

            int primerNumero = 48;
            int segundoNumero = 12;
            primerNumero += segundoNumero;
            primerNumero -= segundoNumero;
            primerNumero *= segundoNumero;
            primerNumero /= segundoNumero;
            primerNumero %= segundoNumero;
            primerNumero++;
            primerNumero--;
            Console.WriteLine("Resultados:{0}", primerNumero);

            bool comparacionY = true && true;
            var comparacionO = true || false;
            bool comparacionIgual = comparacionY == comparacionO;
            bool valorNegado = !comparacionIgual;

            string[] nombres = new string[10];
            nombres[4] = "Ruben";
            string[] diasDeLaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            Console.WriteLine("La semana tiene {0} días", diasDeLaSemana.Length);
            int[] numerosPrimos = { 1, 2, 3, 5, 7, 11 };
            bool[] celdasMarcadas = new bool[16];


            if (DateTime.Now.Minute % 2 == 0)
            {
                Console.WriteLine("Este minuto es par");
            }
            else if (DateTime.Now.Minute == 5)
            {
                Console.WriteLine("Este es el minuto 5");
            }
            else
            {
                Console.WriteLine("Este minuto es impar");
            }


            int rondasFaltantes = 3;
            while (rondasFaltantes > 0)
            {
                Console.WriteLine(rondasFaltantes);
                rondasFaltantes--;
                
            }
            rondasFaltantes = 3;
            do
            {
                Console.WriteLine(rondasFaltantes);
                rondasFaltantes--;
            } while (rondasFaltantes > 0);

            string[] diasSemanales = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            for (int dia = 0; dia < 7; dia++)
            {
                Console.WriteLine("{0} es el número {1} de la semana", diasSemanales[dia], dia + 1);
            }


        }
    }
}
