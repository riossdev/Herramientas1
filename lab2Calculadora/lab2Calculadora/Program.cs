using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab2Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    suma();
                    break;
                case 2:
                    resta();
                    break;
                case 3:
                    multiplicacion();
                    break;
                case 4:
                    divicion();
                    break;
                case 5:
                    raiz();
                    break;
                case 6:
                    potencia();
                    break;

                default:
                    Console.WriteLine("El Opción no es valida");
                    break;
            }
            Console.ReadKey();
        }
        static void menu()
        {
            Console.WriteLine("++++++++  Calculadora +++++++++ ");
            Console.WriteLine("Escoja una opción para realizar la operacion requerida " + "\n");
            Console.WriteLine("Opción 1 para Sumar");
            Console.WriteLine("Opción 2 para Restar");
            Console.WriteLine("Opción 3 para Multiplicar");
            Console.WriteLine("Opción 4 para Dividir");
            Console.WriteLine("Opción 5 para sacar raiz cuadrada ");
            Console.WriteLine("Opción 6 para sacar potencia de un numero" + "\n");
        }
        static void suma()
        {
            int n1, n2, suma = 0;
            Console.WriteLine("**** Suma de numeros enteros  ****");
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine()); 

            suma = n1 + n2;
            Console.WriteLine($"La suma de los dos numero enteros es: {suma }");
        }
        static void resta()
        {
            int n1, n2, resta = 0;
            Console.WriteLine("**** Resta de numeros enteros  ****");
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            resta = n1 - n2;
            Console.WriteLine($"La resta de los dos numero enteros es: {resta}");
        }
        static void multiplicacion()
        {
            int n1, n2, multiplicacion = 0;
            Console.WriteLine("**** Multiplicacion de numeros enteros  ****");
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            multiplicacion = n1 * n2;
            Console.WriteLine($"La multiplicacion de los dos numero enteros es: {multiplicacion}");
        }
        static void divicion()
        {
            int n1, n2, divicion = 0;
            Console.WriteLine("**** Divicion de numeros enteros  ****");
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            divicion = n1 / n2;
            Console.WriteLine($"La divicion de los dos numero enteros es: {divicion}");
        }
        static void raiz()
        {
            double n1, raiz = 0;
            Console.WriteLine("**** Raiz de un numero entero  ****");
            Console.WriteLine("Ingrese el numero");
            n1 = int.Parse(Console.ReadLine());
            raiz = Math.Sqrt(n1);
            Console.WriteLine($"La raiz cuadrada del numero  es: {raiz}");
        }
        static void potencia()
        {
            double n1, potencia = 0;
            Console.WriteLine("**** Numero elevado a al cuadrado  ****");
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            
            potencia = Math.Pow(n1, 2);
            Console.WriteLine($"La  de los dos numero enteros es: {potencia}");
        }
    }
}
