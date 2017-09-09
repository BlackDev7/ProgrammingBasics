using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string minus = new string('a', n - 2).Replace("a", "- ");
            Console.WriteLine("+ {0}+", minus);

            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("| {0}|", minus);
            }

            Console.WriteLine("+ {0}+", minus);
        }
    }
}
