using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2IMC
{
    internal class Program
    {
        static void Main(string[] args)
  
        {
            Console.Write("Ingrese su peso en kilogramos: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = CalcularIMC(peso, altura);

            Console.WriteLine($"Su IMC es: {imc}");
            Console.WriteLine($"Clasificación de IMC: {ClasificarIMC(imc)}");

            Console.ReadKey();
        }

        static double CalcularIMC(double peso, double altura)
        {
            if (altura <= 0)
            {
                Console.WriteLine("Altura no válida. Debe ser mayor que cero.");
                return 0;
            }

            return peso / Math.Pow(altura, 2);
        }

        static string ClasificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Bajo peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                return "Obesidad Clase I (Moderada)";
            }
            else if (imc >= 35 && imc < 40)
            {
                return "Obesidad Clase II (Severa)";
            }
            else
            {
                return "Obesidad Clase III (Muy Severa o Mórbida)";
            }
        }
    }
}
