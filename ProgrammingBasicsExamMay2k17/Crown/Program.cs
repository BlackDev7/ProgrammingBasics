using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));

            for(int i = 0; i <= n/2 ; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}", new string('.', i), new string('-', n - 3 - (2 * i)), new string('.', (2*i-1)));
            }

            Console.WriteLine(new string('*', 2*n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));



            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("@" + new string(' ', ((2 * n) - 4) / 2) + "@" + new string(' ', ((2 * n) - 4) / 2) + "@");
            Console.WriteLine("**" + new string(' ', ((2 * n) - 4) / 2 - 1) + "*" + new string(' ', ((2 * n) - 4) / 2 - 1) + "**");
            for (int i = 1; i <= n / 2 - 2; i++)
            {
                Console.WriteLine("*" + new string('.', i) + "*" + new string(' ', n - 4 - (i * 2 - 1)) + "*" + new string('.', (i * 2 - 1)) + "*" + new string(' ', n - 4 - (i * 2 - 1)) + "*" + new string('.', i) + "*");
            }
            Console.WriteLine('*' + new string('.', n / 2 - 1) + "*" + new string('.', n - 3) + "*" + new string('.', n / 2 - 1) + '*');
            Console.WriteLine('*' + new string('.', n / 2) + new string('*', (n - 4) / 2) + '.' + new string('*', (n - 4) / 2) + new string('.', n / 2) + '*');
            Console.WriteLine(new string('*', (2 * n) - 1));
            Console.WriteLine(new string('*', (2 * n) - 1));

        }

    }
}