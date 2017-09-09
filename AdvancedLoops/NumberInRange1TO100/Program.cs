using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1TO100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            bool isInRange = false;
            do
            {
                n = int.Parse(Console.ReadLine());
                if(n >= 1 && n <= 100)
                {
                    isInRange = true;
                    Console.WriteLine(n);
                }
            } while (!isInRange);
        }
    }
}
