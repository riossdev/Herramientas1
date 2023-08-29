using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cGrados = 0.0f;
            float fahrenheit = 0.0f;

            Console.WriteLine("Pasar Grados Celcius a Fahrenheit ");
            Console.WriteLine("Ingrese los grados celcius ");
            cGrados = float.Parse(Console.ReadLine()); 


            fahrenheit = (cGrados * 9 / 5) + 32;

            Console.WriteLine("El los grados fahrenheit es: " + fahrenheit);

            Console.ReadKey();
        }
    }
}
