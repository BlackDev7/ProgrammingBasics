using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= number; i++)
            {
                string spaces = new string(' ', number - i);
 
                string asterisks = new string('*', i);
                Console.WriteLine("{0}{1} | {1}{0}", spaces, asterisks);
            }

        }
    }
}
