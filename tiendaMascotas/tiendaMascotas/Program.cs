using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaMascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int perrito1, perrito2, perrito3 = 0;
            Console.WriteLine("Por favor ingrese la edad del Primer perrito ");
            perrito1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la edad del Segundo perrito ");
            perrito2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la edad del Tercer perrito ");
            perrito3 = int.Parse(Console.ReadLine());

            if((perrito1 > perrito2) && (perrito1 > perrito3))
            {
                Console.WriteLine("El perrito 1 es mayor tiene " + perrito1 + " Años por lo tanto te llevas perrito 2 y 3 ");
            }
            else if((perrito2 > perrito1) && (perrito2 > perrito3))
            {
                Console.WriteLine("El perrito 2 es mayor tiene " + perrito2 + " Años por lo tanto te llevas perrito 1 y 3 ");
            }
            else
            {
                Console.WriteLine("El perrito 3 es mayor tiene " + perrito3 + " Años por lo tanto te llevas perrito 1 y 2 ");
            }
            Console.ReadKey();
        }
        
    }
    
}
