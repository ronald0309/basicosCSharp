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


        }
    }
}
