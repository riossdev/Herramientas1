using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int factorial = 1

            Console.WriteLine("Factorial de un numero");
            Console.WriteLine("Ingresa el numero ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
