using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInput = double.Parse(Console.ReadLine());
            string givenCurrency = Console.ReadLine();
            string neededCurrency = Console.ReadLine();
            double moneyInLv = 0;
            switch(givenCurrency)
            {
                case "USD":
                    moneyInLv =  moneyInput * 1.79549;
                    break;
                case "EUR":
                    moneyInLv = moneyInput * 1.95583;
                    break;
                case "GBP":
                    moneyInLv = moneyInput * 2.53405;
                    break;
                default:
                    moneyInLv = moneyInput;
                    break;
            }

            switch(neededCurrency)
            {
                case "BGN":
                    Console.WriteLine("{0:F2} BGN", moneyInLv);
                    break;
                case "USD":
                    Console.WriteLine("{0:F2} USD", moneyInLv / 1.79549);
                    break;
                case "EUR":
                    Console.WriteLine("{0:F2} EUR", moneyInLv / 1.95583);
                    break;
                case "GBP":
                    Console.WriteLine("{0:F2} GBP", moneyInLv / 2.53405);
                    break;
            }
        }
    }
}
