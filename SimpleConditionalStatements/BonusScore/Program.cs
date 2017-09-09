using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonus = 0;

            if (number < 100)
            {
                bonus  = 5;
            }
            else if (number < 1000) 
            {
                bonus = ((number / 100) * 20);
            }
            else
            {
                bonus = ((number / 100) * 10);
            }

            if(number % 2 == 0)
            {
                bonus += 1;
            }
            if ((number % 10) == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
