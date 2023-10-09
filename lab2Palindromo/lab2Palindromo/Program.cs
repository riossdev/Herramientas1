using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            Console.Write("Ingrese una palabra o frase para verificar si es un palíndromo: \n ");
            string input = Console.ReadLine();

            if (EsPalindromo(input))
            {
                Console.WriteLine($"{input} es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"{input} no es un palíndromo.");
            }
            Console.ReadKey();
        }

        static bool EsPalindromo(string texto)
        {
            string textoFormateado = texto.Replace(" ", "").ToLower();
            return textoFormateado == Reverso(textoFormateado);
        }

        static string Reverso(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
