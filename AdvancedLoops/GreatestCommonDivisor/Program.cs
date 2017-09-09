using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {

            int a  = int.Parse(Console.ReadLine());
            int b =  int.Parse(Console.ReadLine());
            int Remainder;
            while (b != 0)
            {

                Remainder = a % b;
                a = b;
                b = Remainder;
            }
            Console.WriteLine(a);
        }
    }
}
