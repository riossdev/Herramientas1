using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            int primo = 0;

            Console.WriteLine("Numero primo");
            Console.WriteLine("Ingrese el numero de ");
            num = int.Parse(Console.ReadLine());    

            primo = num % 2;
            
            if(primo != 0)
            {
                Console.WriteLine("Este es un numero primo");
            }
            else
            {
                Console.WriteLine("No es un numero primo ");
            }
            Console.ReadKey();

        }

    }
}
