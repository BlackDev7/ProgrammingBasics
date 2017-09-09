using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] leftNumbers = new int[numberCount];
            int[] rightNumbers = new int[numberCount];
            for (int i = 1; i <= numberCount; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                leftNumbers[i - 1] = numberInput;
            }
            for (int i = 1; i <= numberCount; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                rightNumbers[i - 1] = numberInput;
            }
            int leftNumbersSum = leftNumbers.Sum();
            int rightNumbersSum = rightNumbers.Sum();
            int difference = Math.Abs(leftNumbersSum - rightNumbersSum);
            if(difference == 0)
            {
                Console.WriteLine("Yes, sum = {0}", leftNumbersSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", difference);
            }

        }
    }
}
