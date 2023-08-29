using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace operacionesMatematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opc = 0;
            int num1 = 0;
            int num2 = 0;
            float operacion = 0;

            Console.WriteLine(" *** MENU ***");
            Console.WriteLine("Que operacion aritmetica desea realizar ");
            Console.WriteLine("Opción 1 para Suma ");
            Console.WriteLine("Opción 2 para Resta ");
            Console.WriteLine("Opción 1 para Multiplicacion ");
            Console.WriteLine("Opción 1 para Divicion ");
            opc = int.Parse(Console.ReadLine());

            if((opc < 1) || (opc > 4)) 
            {
                Console.WriteLine("La operacion no es validad " ); 
            }
            else if(opc == 1)
            {
                Console.WriteLine("Vamos a realizar una Suma de numero enteros");
                Console.WriteLine("Ingrese el primer numero ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero ");
                num2 = int.Parse(Console.ReadLine());

                operacion = num1 + num2;

                Console.WriteLine("La suma de los dos numero es " + operacion);
            }
            else if(opc == 2)
            {
                Console.WriteLine("Vamos a realizar una Resta de numero enteros");
                Console.WriteLine("Ingrese el primer numero ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero ");
                num2 = int.Parse(Console.ReadLine());

                operacion = num1 - num2;

                Console.WriteLine("La resta de los dos numero es " + operacion);
            }
            else if (opc == 3)
            {
                Console.WriteLine("Vamos a realizar una Multiplicación de numero enteros");
                Console.WriteLine("Ingrese el primer numero ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero ");
                num2 = int.Parse(Console.ReadLine());

                operacion = num1 * num2;

                Console.WriteLine("La multiplicacion de los dos numero es " + operacion);
            }
            else if(opc == 4)
            {
                Console.WriteLine("Vamos a realizar una Divicion de numero enteros");
                Console.WriteLine("Ingrese el primer numero ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero ");
                num2 = int.Parse(Console.ReadLine());

                operacion = num1 / num2;

                Console.WriteLine("La Divicion de los dos numero es " + operacion);
            }
            Console.ReadKey();
        }
    }
}
