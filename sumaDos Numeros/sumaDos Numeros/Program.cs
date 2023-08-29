using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaDos_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;

            Console.WriteLine(" *** Suma De Dos Numeros Enteros ***");
            Console.WriteLine("Ingrese el valor del perimer numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("la suma de los dos numero es " + suma);
            Console.ReadKey();
        }
        
    }
    
}
