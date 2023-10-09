using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2CalculoEdad
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            Console.Write("Ingrese su fecha de nacimiento (yyyy-MM-dd): ");
            string fecha = Console.ReadLine();

            if (DateTime.TryParse(fecha, out DateTime fechaNacimiento))
            {
                int edad = CalcularEdad(fechaNacimiento);

                if (edad >= 0)
                {
                    Console.WriteLine($"Usted tiene {edad} años.");
                }
                else
                {
                    Console.WriteLine("La fecha de nacimiento debe ser anterior a la fecha actual.");
                }
            }
            else
            {
                Console.WriteLine("Formato de fecha incorrecto. Por favor, ingrese una fecha válida.");
            }
            Console.ReadKey();
        }

        static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            if (fechaNacimiento > fechaActual)
            {
                return -1; 
            }

            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }
    }
}
