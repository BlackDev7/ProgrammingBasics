using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= numberCount; i++)
            {
                int xNumber = int.Parse(Console.ReadLine());
                sum += xNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
