using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaNumeroBwhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("**  Tabla de Multiplicar de un Numéro ** ");
            Console.WriteLine("Ingrese el numero para saber su tabla de multiplicar ");
            num = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
                i++;
            }
            Console.ReadKey();
        }
    }
}
