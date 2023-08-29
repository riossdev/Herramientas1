using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parOimpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int res = 0;

            Console.WriteLine("Numero par o impar ");
            Console.WriteLine("Ingrese un numero ");
            num =  int.Parse(Console.ReadLine());

            res = num % 2;

            if (res == 0)
            {
                Console.WriteLine("EL numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();  

        }
    }
}
