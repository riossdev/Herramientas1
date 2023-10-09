using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2GeneradorContraseñas
{
    internal class Program
    {
        static void Main(string[] args)
         
        {
            Console.Write("Longitud de la contraseña: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            string contraseña = GenerarContraseña(longitud);

            Console.WriteLine($"Contraseña generada: {contraseña}");
            Console.ReadKey();  
        }

        static string GenerarContraseña(int longitud)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+";

            Random random = new Random();
            string contraseñaGenerada = new string(Enumerable.Repeat(caracteres, longitud)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return contraseñaGenerada;
        }
    }
}
