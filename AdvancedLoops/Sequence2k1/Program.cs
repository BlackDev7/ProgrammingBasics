using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2k1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            while(currentNum <= n)
            {
                Console.WriteLine(currentNum);
                currentNum = (currentNum*2) + 1;
            }
        }
    }
}
