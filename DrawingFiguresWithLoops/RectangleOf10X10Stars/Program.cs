using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOf10X10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                string asterisks = new string('*', 10);
                Console.WriteLine(asterisks);
            }
        }
    }
}
