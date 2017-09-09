using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHeHas = double.Parse(Console.ReadLine());
            int yearBack = int.Parse(Console.ReadLine());
            int currentAge = 18;
            double moneySpent = 0;

            for(int i = 1800; i <= yearBack; i++)
            {
                if (i % 2 == 0)
                    moneySpent += 12000;
                else
                    moneySpent += 12000 + (50 * currentAge);

                currentAge++;
            }
            if(moneyHeHas >= moneySpent)
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", moneyHeHas - moneySpent);
            else
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(moneyHeHas - moneySpent));
        }
    }
}
