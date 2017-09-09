using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string commas = new string('.', n);
            Console.WriteLine("{0}{1}{0}", commas, new string('*', 3*n));

            for (int i = n - 1; i > 0; i--) 
            {

                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', ((5 * n - 2 - 2 * i))));

            }
            Console.WriteLine(new string('*', 5*n));
            int k = 1;
            for (k = 1; k <= 2 * n; k++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', k), new string('.', (5 * n - 2 - 2 * k)));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', k), new string('*', (5 * n - 2 - 2 * k)));

        }
    }
}
