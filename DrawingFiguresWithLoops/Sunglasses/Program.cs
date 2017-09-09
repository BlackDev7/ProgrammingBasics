using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string asterisks = new string('*', 2*n);
            string spaces = new string(' ', n);
            string slashes = new string('/', (2*n) - 2);
            string verticalBars = new string('|', n);
            Console.WriteLine("{0}{1}{0}", asterisks, spaces);
            for (int i = 1; i <= n - 2; i++)
            {
                if(i == ((n - 1) / 2))
                {
                    Console.WriteLine("*{0}*{1}*{0}*", slashes,verticalBars);
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", slashes, spaces);
                }
  
            }
            Console.WriteLine("{0}{1}{0}", asterisks, spaces);
        }
    }
}
