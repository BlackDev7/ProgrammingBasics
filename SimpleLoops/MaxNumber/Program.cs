using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] allNumbers = new int[numberCount] ;
            for (int i = 1; i <= numberCount; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                allNumbers[i-1] = numberInput;
            }
            Console.WriteLine(allNumbers.Max());
        }
    }
}
