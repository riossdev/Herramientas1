using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcadoParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = { "colegio" } ;
            Random rand = new Random();
            string palabraSecreta = palabras[rand.Next(palabras.Length)];
            char[] palabraUsuario = new char[palabraSecreta.Length];
            int intentosRestantes = 6;

            for (int i = 0; i < palabraUsuario.Length; i++)
            {
                palabraUsuario[i] = '_';
            }

            Console.WriteLine("¡Bienvenido al Juego del Ahorcado!");
            Console.WriteLine("Palabra secreta: " + string.Join(" ", palabraUsuario));

            while (intentosRestantes > 0)
            {
                Console.Write("Ingresa una letra: ");
                char letra = Console.ReadKey().KeyChar;
                bool letraAdivinada = false;

                for (int i = 0; i < palabraSecreta.Length; i++)
                {
                    if (palabraSecreta[i] == letra)
                    {
                        palabraUsuario[i] = letra;
                        letraAdivinada = true;
                    }
                }

                if (!letraAdivinada)
                {
                    intentosRestantes--;
                }

                Console.WriteLine("\nIntentos restantes: " + intentosRestantes);
                Console.WriteLine("Palabra secreta: " + string.Join(" ", palabraUsuario));

                if (string.Join("", palabraUsuario) == palabraSecreta)
                {
                    Console.WriteLine("¡Ganaste! La palabra secreta era: " + palabraSecreta);
                    break;
                }
            }

            if (intentosRestantes == 0)
            {
                Console.WriteLine("¡Ahorado! La palabra secreta era: " + palabraSecreta);
            }
            Console.ReadKey();
        }
    }
}