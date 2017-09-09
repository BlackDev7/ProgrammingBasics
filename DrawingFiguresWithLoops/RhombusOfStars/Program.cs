using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int row = 1; row <= number - 1; row++)
            {
                string space = new string(' ', number - row);
                string asterisks = new string('a', row - 1).Replace("a", " *");
                Console.WriteLine("{0}*{1}",space, asterisks);
            }

            Console.WriteLine(new string('a', number).Replace("a", "* "));

            for (int row = number - 1; row > 0; row--)
            {
                string space = new string(' ', number - row);
                string asterisks = new string('a', row - 1).Replace("a", " *");
                Console.WriteLine("{0}*{1}", space, asterisks);
            }

        }
    }
}
