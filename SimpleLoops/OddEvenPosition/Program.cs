using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            double[] evenNumbers = new double[numberCount];
            double[] oddNumbers = new double[numberCount];
            if (numberCount > 0)
            {
                for (int i = 1; i <= numberCount; i++)
                {
                    double numberInput = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evenNumbers[i-1] = numberInput;
                    }
                    else
                    {
                        oddNumbers[i-1] = numberInput;
 
                    }
                }
                double oddSum = oddNumbers.Sum();
                double oddMin = oddNumbers.Min();
                double oddMax = oddNumbers.Max();
                double evenSum = evenNumbers.Sum();
                double evenMin = evenNumbers.Min();
                double evenMax = evenNumbers.Max();

                Console.WriteLine("OddSum={0}", oddSum);
                if (oddMin > 0) { Console.WriteLine("oddMin={0}", oddMin); }
                else { Console.WriteLine("OddMin=No"); }
                if (oddMax > 0) { Console.WriteLine("OddMax={0}", oddMax); }
                else { Console.WriteLine("OddMax=No"); }
                Console.WriteLine("evenSum={0}", evenSum);
                if (evenMin > 0) { Console.WriteLine("evenMin={0}", evenMin); }
                else { Console.WriteLine("evenMin=No"); }
                if (evenMax > 0) { Console.WriteLine("evenMax={0}", evenMax); }
                else { Console.WriteLine("evenMax=No"); }  
            }
            else
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("evenSum=0");
                Console.WriteLine("evenMin=No");
                Console.WriteLine("evenMax=No");
            }
        }
            
    }
}
