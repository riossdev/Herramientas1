using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Pelota
{
    class Pelota
    {
        public string Tipo { get; set; }
        public double Diametro { get; set; }

        public Pelota(string tipo, double diametro)
        {
            Tipo = tipo;
            Diametro = diametro;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Pelota> pelotas = new List<Pelota>();

            Console.WriteLine("Ingresar información de pelotas (Ingrese 'salir' para finalizar)");

            while (true)
            {
                Console.WriteLine("Ingrese el tipo de pelota (fútbol, baloncesto, etc.):");
                string tipo = Console.ReadLine();

                if (tipo.ToLower() == "salir")
                    break;

                Console.WriteLine("Ingrese el diámetro de la pelota (en cm):");
                double diametro = Convert.ToDouble(Console.ReadLine());

                Pelota pelota = new Pelota(tipo, diametro);
                pelotas.Add(pelota);
            }

            Console.WriteLine("\nInformación de las Pelotas:");

            foreach (var pelota in pelotas)
            {
                Console.WriteLine($"Tipo de Pelota: {pelota.Tipo}");
                Console.WriteLine($"Diámetro: {pelota.Diametro} cm");
                Console.WriteLine();
            }
        }
    }
}
