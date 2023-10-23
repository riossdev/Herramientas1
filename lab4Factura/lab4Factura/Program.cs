using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Factura
{
    class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }

    class Factura
    {
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public List<Producto> Productos { get; set; }

        public Factura(int numeroFactura, DateTime fecha)
        {
            NumeroFactura = numeroFactura;
            Fecha = fecha;
            Productos = new List<Producto>();
        }

        public void AgregarProducto(string nombre, double precio)
        {
            Producto producto = new Producto(nombre, precio);
            Productos.Add(producto);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var producto in Productos)
            {
                total += producto.Precio;
            }
            return total;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Factura> facturas = new List<Factura>();

            Console.WriteLine("Ingresar información de facturas (Ingrese 'salir' para finalizar)");

            while (true)
            {
                Console.WriteLine("Ingrese el número de factura:");
                int numeroFactura = Convert.ToInt32(Console.ReadLine());

                if (numeroFactura == 0)
                    break;

                Console.WriteLine("Ingrese la fecha de la factura (YYYY-MM-DD):");
                DateTime fecha = DateTime.Parse(Console.ReadLine());

                Factura factura = new Factura(numeroFactura, fecha);

                Console.WriteLine("Ingresar productos (Ingrese 'fin' para finalizar)");

                while (true)
                {
                    Console.WriteLine("Nombre del producto:");
                    string nombreProducto = Console.ReadLine();

                    if (nombreProducto.ToLower() == "fin")
                        break;

                    Console.WriteLine("Precio del producto:");
                    double precioProducto = Convert.ToDouble(Console.ReadLine());

                    factura.AgregarProducto(nombreProducto, precioProducto);
                }

                facturas.Add(factura);
            }

            Console.WriteLine("\nTotal de las Facturas:");

            foreach (var factura in facturas)
            {
                Console.WriteLine($"Número de Factura: {factura.NumeroFactura}");
                Console.WriteLine($"Fecha: {factura.Fecha.ToShortDateString()}");
                Console.WriteLine($"Total: ${factura.CalcularTotal():F2}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
