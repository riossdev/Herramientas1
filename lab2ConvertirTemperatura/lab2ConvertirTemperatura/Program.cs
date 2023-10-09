using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2ConvertirTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                menu();

                Console.Write("Elija una opción : \n ");
                string opcion = Console.ReadLine();

                if (opcion == "0")
                {
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }

                RealizarConversion(opcion);
            }
        }

        static void menu()
        {
            Console.WriteLine("Menú de Conversión de Temperatura:");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("4. Kelvin a Celsius");
            Console.WriteLine("0. Salir \n");
        }

        static void RealizarConversion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    CelsiusAFahrenheit();
                    break;
                case "2":
                    FahrenheitACelsius();
                    break;
                case "3":
                    CelsiusAKelvin();
                    break;
                case "4":
                    KelvinACelsius();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }

        static void CelsiusAFahrenheit()
        {
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius} grados Celsius son equivalentes a {fahrenheit} grados Fahrenheit");
        }

        static void FahrenheitACelsius()
        {
            Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{fahrenheit} grados Fahrenheit son equivalentes a {celsius} grados Celsius");
        }

        static void CelsiusAKelvin()
        {
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = celsius + 273.15;

            Console.WriteLine($"{celsius} grados Celsius son equivalentes a {kelvin} Kelvin");
        }

        static void KelvinACelsius()
        {
            Console.Write("Ingrese la temperatura en Kelvin: ");
            double kelvin = Convert.ToDouble(Console.ReadLine());

            double celsius = kelvin - 273.15;

            Console.WriteLine($"{kelvin} Kelvin son equivalentes a {celsius} grados Celsius");
        }
    }
}
