using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] evenNumbers = new int[numberCount];
            int[] oddNumbers = new int[numberCount];
            for (int i = 1; i <= numberCount; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                if (i  % 2 == 0)
                {
                    evenNumbers[i - 1] = numberInput;
                }
                else
                {
                    oddNumbers[i - 1] = numberInput;
                }
            }
            int difference = Math.Abs(evenNumbers.Sum() - Math.Abs(oddNumbers.Sum()));
            if(difference == 0)
            {
                Console.WriteLine("Yes, sum = {0}", evenNumbers.Sum());
            }
            else
            {
                Console.WriteLine("No, diff = {0}", difference);
            }
        }
    }
}
