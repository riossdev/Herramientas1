using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Rectangulo
{
    class Rectangulo
    {
       
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }
        public double CalcularArea()
        {
            return Ancho * Alto;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el ancho del rectángulo:");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el alto del rectángulo:");
            double alto = Convert.ToDouble(Console.ReadLine());

            Rectangulo rectangulo = new Rectangulo(ancho, alto);

            Console.WriteLine("Rectángulo:");
            Console.WriteLine($"Ancho: {rectangulo.Ancho}, Alto: {rectangulo.Alto}");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");

            Console.ReadKey();
        }
    }
}
