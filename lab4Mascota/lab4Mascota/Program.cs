using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Mascota
{
    class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoAnimal { get; set; }

        public Mascota(string nombre, int edad, string tipoAnimal)
        {
            Nombre = nombre;
            Edad = edad;
            TipoAnimal = tipoAnimal;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Mascota> mascotas = new List<Mascota>();

            Console.WriteLine("Ingresar información de mascotas (Ingrese 'salir' para finalizar)");

            while (true)
            {
                Console.WriteLine("Ingrese el nombre de la mascota:");
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "salir")
                    break;

                Console.WriteLine("Ingrese la edad de la mascota:");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el tipo de animal (perro, gato, etc.):");
                string tipoAnimal = Console.ReadLine();

                Mascota mascota = new Mascota(nombre, edad, tipoAnimal);
                mascotas.Add(mascota);
            }

            Console.WriteLine("\nDatos de las Mascotas:");

            foreach (var mascota in mascotas)
            {
                Console.WriteLine($"Nombre: {mascota.Nombre}");
                Console.WriteLine($"Edad: {mascota.Edad} años");
                Console.WriteLine($"Tipo de Animal: {mascota.TipoAnimal}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
