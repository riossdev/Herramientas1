using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2AreaPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("*** Elija en el menu la figura que de sea calcular *** \n ");
                menu();

                string opcion = Console.ReadLine();

                if (opcion == "0")
                {
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }

                CalcularFigura(opcion);
            }
        }

        static void menu()
        {
            Console.WriteLine("\nMenú de Figuras Geométricas:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Cuadrado");
            Console.WriteLine("0. Salir \n");
        }

        static void CalcularFigura(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Circulo();
                    break;
                case "2":
                    Triangulo();
                    break;
                case "3":
                    Rectangulo();
                    break;
                case "4":
                    Cuadrado();
                    break;
                default:
                    Console.WriteLine("Opción no válida. ");
                    break;
            }
        }

        static void Circulo()
        {
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radio, 2);
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"Área del círculo: {area}");
            Console.WriteLine($"Perímetro del círculo: {perimetro}");
        }

        static void Triangulo()
        {
            Console.Write("Ingrese la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseTriangulo * alturaTriangulo;
            double perimetro = baseTriangulo * 3;

            Console.WriteLine($"Área del triángulo: {area}");
            Console.WriteLine($"Perímetro del triángulo: {perimetro}");
        }

        static void Rectangulo()
        {
            Console.Write("Ingrese la base del rectángulo: ");
            double baseRectangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

            double area = baseRectangulo * alturaRectangulo;
            double perimetro = 2 * (baseRectangulo + alturaRectangulo);

            Console.WriteLine($"Área del rectángulo: {area}");
            Console.WriteLine($"Perímetro del rectángulo: {perimetro}");
        }

        static void Cuadrado()
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

            double area = Math.Pow(ladoCuadrado, 2);
            double perimetro = 4 * ladoCuadrado;

            Console.WriteLine($"Área del cuadrado: {area}");
            Console.WriteLine($"Perímetro del cuadrado: {perimetro}");
        }
    }
}
