using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] allNumbers = new int[2 * numberCount];
            for (int i = 1; i <= 2 * numberCount; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                allNumbers[i - 1] = numberInput;
            }
            int currentDifference = 0;
            int tempSum = 0;
            for (int i = 0; i < allNumbers.Length - 1; i += 2)
            {

                if ((i > 1) && (allNumbers[i] + allNumbers[i + 1]) > tempSum)
                {
                    currentDifference = Math.Abs((allNumbers[i] + allNumbers[i + 1] - tempSum));
                }
                tempSum = (allNumbers[i] + allNumbers[i + 1]);

            }
            if (currentDifference > 0)
            {
                Console.WriteLine("No, maxdiff={0}", currentDifference);
            }
            else
            {
                Console.WriteLine("Yes, value = {0}", tempSum);
            }

        }
    }
}
