using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int[] fibonacci = new int[n];
                fibonacci[0] = 1;
                fibonacci[1] = 2;
                for (int i = 2; i < fibonacci.Length; i++)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }
                Console.WriteLine(fibonacci.Last());
            }


        }
    }
}
