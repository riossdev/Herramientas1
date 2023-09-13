using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serieFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fibo = 1;
            int alma = 0;
            int temp = 0;
            for(int i = 1; i <= 8; i++)
            {
                temp = alma;
                alma =  fibo;
                fibo = temp + alma;
                
                Console.WriteLine(fibo);

               
            }
            Console.ReadKey();
        }
    }
}
