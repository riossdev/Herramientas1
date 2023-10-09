using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            Console.Write("Secuencia de Fibonacci ");
            Console.WriteLine("Ingrese los numeros a generar");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Secuencia de Fibonacci:");

            for (int i = 0; i < num; i++)
            {
                Console.Write(CalcularFibonacci(i) + " ");
            }
            Console.ReadKey();
        }

        static int CalcularFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
            }
        }
    }
}
