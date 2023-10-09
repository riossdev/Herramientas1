using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionVectoresFunciones
{
    internal class Program
    {

        static int[] numControl;
        static string[] nombres;
        static double[] calificaciones;

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        limpiar();
                        break;
                    case 2:
                        capturar();
                        break;
                    case 3:
                        promedio();
                        break;
                    case 4:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("La opcion no existe");
                        break;
                }
            } while (opcion != 4);
        }

        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 Limpiar datos estudiante"); ;
            Console.WriteLine("2 Capturar datos estudiante ");
            Console.WriteLine("3 Promedio");
            Console.WriteLine("4 Salir");
        }
        static void limpiar()
        {
            Console.WriteLine("Limpiando datos");
            numControl = null;
            nombres = null;
            calificaciones = null;
        }
        static void capturar()
        {
            //Console.WriteLine("Caprurando");
            Console.Write("cantidad de estudiantes: ");
            int numEstudiantes = int.Parse(Console.ReadLine());

            numControl = new int[numEstudiantes];
            nombres = new string[numEstudiantes];
            calificaciones = new double[numEstudiantes];

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.Write($"Ingrese el numero de estudiantes {i + 1}: ");
                numControl[i] = int.Parse(Console.ReadLine());
               

                Console.Write($"nombre del estudiante {i + 1}: ");
                nombres[i] = Console.ReadLine();
                    
                Console.Write($"calificación del estudiante {i + 1}: ");
                calificaciones[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Datos capturados..........");
        }
        static void promedio()
        {
            if (numControl == null || numControl.Length == 0)
            {
                Console.WriteLine("No hay datos de estudiantes para calcular el promedio.");
                return;
            }

            double sumaCalificaciones = 0;

            for (int i = 0; i < numControl.Length; i++)
            {
                sumaCalificaciones += calificaciones[i];
            }

            double promedio = sumaCalificaciones / numControl.Length;

            Console.WriteLine($"El promedio de calificaciones es: {promedio:F2}");
        }
    }
}
