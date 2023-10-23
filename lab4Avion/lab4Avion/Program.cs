using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Avion
{
    class Avion
    {
      
        public string Modelo { get; set; }
        public int CapacidadPasajeros { get; set; }
        public int VelocidadMaxima { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Avión:");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacidad de Pasajeros: {CapacidadPasajeros}");
            Console.WriteLine($"Velocidad Máxima: {VelocidadMaxima} km/h");
        }
    }
    class Program
    {
        static void Main()
        {
            List<Avion> aviones = new List<Avion>();

            Console.WriteLine("Ingresar información de aviones (Ingrese 'salir' para finalizar)");

            while (true)
            {
                Console.WriteLine("Ingrese el modelo del avión:");
                string modelo = Console.ReadLine();

                if (modelo.ToLower() == "salir")
                    break;

                Console.WriteLine("Ingrese la capacidad de pasajeros del avión:");
                int capacidadPasajeros = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la velocidad máxima del avión (en km/h):");
                int velocidadMaxima = Convert.ToInt32(Console.ReadLine());

                Avion avion = new Avion
                {
                    Modelo = modelo,
                    CapacidadPasajeros = capacidadPasajeros,
                    VelocidadMaxima = velocidadMaxima
                };

                aviones.Add(avion);
            }

            Console.WriteLine("\nInformación de los Aviones:");

            foreach (var avion in aviones)
            {
                avion.MostrarInformacion();
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}
