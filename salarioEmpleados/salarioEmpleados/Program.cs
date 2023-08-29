using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarioEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario1, salario2 = 0;

            Console.WriteLine("Ingrese el salario del primer trabajador ");
            salario1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el salario del segundo trabajador ");
            salario2 = float.Parse(Console.ReadLine());

            if(salario1 == salario2)
            {
                Console.WriteLine("El salario para ambos trabajadores es igual " + salario1 +  " " + salario2);

            }
            else if(salario1 >= salario2)
            {
                Console.WriteLine("El salario del primer trabajador es mayor " + salario1);
            }
            else
            {
                Console.WriteLine("El salario del segundo tabajador es Mayor " + salario2);
            }
            Console.ReadKey();
        }
    }
}
