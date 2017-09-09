using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] allNumbers = new int[numberCount];
            for (int i = 1; i <= numberCount; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                allNumbers[i - 1] = numberInput;
            }
            int maxFromNumbers = allNumbers.Max();
            int sumOfOtherNumbers = (allNumbers.Sum() - maxFromNumbers);
            int difference = 0;
            if(maxFromNumbers == sumOfOtherNumbers)
            {
                Console.WriteLine("Yes, sum = {0}", sumOfOtherNumbers);
            }
            else
            {
                difference = Math.Abs(maxFromNumbers - sumOfOtherNumbers);
                Console.WriteLine("No, Diff = {0}", difference);
            }
        }
    }
}
