using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionUnidades
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            int opcion = 0;
            Menu();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    longitud();
                    break;
                case 2:
                    peso();
                    break;
                case 3:
                    volumen();
                    break;
                default:
                    Console.WriteLine("La opción no es valida");
                    break;
            }
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.WriteLine("***** Menu Conversion de Unidades *****");
            Console.WriteLine("\nOpción 1: Cambiar de metros a centimetros.");
            Console.WriteLine("Opción 2: Cambiar kilogramos en libras  ");
            Console.WriteLine("Opcion 3: Cambiar volumen en litros \n");
        }
        static void longitud()
        {
            double metro, centimetros, pies, pulgadas  = 0;
            Console.WriteLine("Ingrese el valor en metros para hallar sus equivalencias ");
            metro = double.Parse(Console.ReadLine());

            pulgadas = metro * 39.37;
            centimetros = metro * 100;
            pies = metro * 3.281;

            Console.WriteLine($"{ metro } metro es equivalentes a: ");
            Console.WriteLine($"{ pulgadas } pulgadas " );
            Console.WriteLine($"{ centimetros } centimetros ");
            Console.WriteLine($"{ pies } pies ");
        }

        static void peso()
        {
            double kilogramos, libras = 0;
            Console.WriteLine("Ingrese el valor en kilogramos para cambiarlos a libras ");
            kilogramos = double.Parse(Console.ReadLine());

            libras = kilogramos * 2.205;

            Console.WriteLine($"{ kilogramos } su equvalente en libras es: ");
            Console.WriteLine($"{ libras } libras ");
        }
        static void volumen()
        {
            double litros, galones = 0;
            Console.WriteLine("Ingrese el valor en litros ");
            litros = double.Parse(Console.ReadLine());

            galones = litros * 0.264;

            Console.WriteLine($"{ litros } equivalen a: ");
            Console.WriteLine($"{ galones } galones ");
        }
            
    }
}
