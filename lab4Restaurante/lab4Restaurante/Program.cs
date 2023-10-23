using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Restaurante
{
    class Restaurante
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<string> Menu { get; } = new List<string>();

        public Restaurante(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void AgregarPlatoAlMenu(string plato)
        {
            Menu.Add(plato);
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Menú del Restaurante:");
            foreach (var plato in Menu)
            {
                Console.WriteLine(plato);
            }
        }

        public void TomarPedido()
        {
            Console.WriteLine("¿Qué plato desea pedir? (Ingrese 'fin' para finalizar el pedido):");
            string pedido = Console.ReadLine();

            if (Menu.Contains(pedido))
            {
                Console.WriteLine($"Pedido: {pedido}");
            }
            else if (pedido.ToLower() == "fin")
            {
                Console.WriteLine("Pedido finalizado.");
            }
            else
            {
                Console.WriteLine("El plato seleccionado no está en el menú.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Restaurante restaurante = new Restaurante("Mi Restaurante", "Pascual Bravo");

            restaurante.AgregarPlatoAlMenu("Pasta");
            restaurante.AgregarPlatoAlMenu("Pizza");
            restaurante.AgregarPlatoAlMenu("Ensalada");
            restaurante.AgregarPlatoAlMenu("Sopa");
            restaurante.AgregarPlatoAlMenu("Pollo a la Parrilla");

            Console.WriteLine($"Bienvenido al restaurante {restaurante.Nombre}");
            Console.WriteLine($"Dirección: {restaurante.Direccion}\n");

            restaurante.MostrarMenu();

            Console.WriteLine("\nRealizar un pedido:");
            restaurante.TomarPedido();
        }
    }
}
