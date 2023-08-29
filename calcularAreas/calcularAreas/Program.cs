using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Console.WriteLine("              ++++  MENU ++++              ");
            Console.WriteLine("Elija la opción 1: para calcular el area de un triangulo");
            Console.WriteLine("Elija la opción 2: para calcular el area de un cuadrado ");
            Console.WriteLine("Elija la opción 3: para calcular el area de un circulo");
            Console.WriteLine("");
            
            opc = int.Parse(Console.ReadLine());

            if (opc > 3)
            {
                Console.WriteLine("La opcion es invalida");
            }
            else if (opc == 1)
            {
                Console.WriteLine("Vamos a calcular el Area de un triangulo ");
                Console.WriteLine("Ingresa la base ");
                float basee= 0; 
                basee = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la altura ");
                float altura = 0;
                altura = float.Parse(Console.ReadLine());

                float area = (altura * basee) / 2;

                Console.WriteLine("El area del triangulo es " + area);
            }else if (opc == 2)
            {
                Console.Write("Vamos a calcular el Area de un cuadrado ");
                Console.WriteLine("Ingrese el valor del lado del cuadrado ");
                float lado = 0;
                lado = float.Parse(Console.ReadLine());
                float area = 0;
                area = lado * lado;

                Console.WriteLine("El area del cuadrado es  " + area);
            }
            else
            {
                Console.WriteLine("Vamos a calcular el perimetro de un circulo");
                Console.WriteLine("Ingresa el valor del radio ");
                double radio = 0;
                radio = double.Parse(Console.ReadLine());
                double perimetro = 0;
                double pi = 3.14;
                perimetro = (radio * radio) * pi;

                Console.WriteLine("El area del circculo es " + perimetro);
            }
            Console.ReadKey();
        }
    }
}
