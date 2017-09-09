using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysMontly = int.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double dollarToBgn = double.Parse(Console.ReadLine());
            double monthlyIncome = workingDaysMontly * dailyProfit;
            double yearIncome = (monthlyIncome * 12) + (monthlyIncome * 2.5);
            double cleanIncome = yearIncome * 0.75;

            Console.WriteLine("{0:F2}",(cleanIncome * dollarToBgn) / 365);

        }
    }
}
