using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Ingrese el numero para validar si es primo");
            num = int.Parse(Console.ReadLine());
            if (numerosPrimos(num))
            {
                Console.WriteLine($"{ num } es un numero primo");
            }
            else
            {
                Console.WriteLine($"{ num } no es un numero primo");
            }
            Console.ReadKey();
        }
        static bool numerosPrimos(int n)
        {
            if(n <= 1)
            {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(n); i++) 
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
