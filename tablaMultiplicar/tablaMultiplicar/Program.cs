using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            Console.WriteLine("Tabla de Multiplicar");
            Console.WriteLine("Ingrese el numero ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Vamos a realizar la tabla del:  " + num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine( num + " X " + i + "=" +  (num * i));
            }
            Console.ReadKey();

        }
    }
}
