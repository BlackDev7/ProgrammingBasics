using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double peopleCount = double.Parse(Console.ReadLine());
            double price = 0;

            double moneyLeft = budget;
            switch(category)
            {
                case "VIP":
                    price = 499.99;
                    break;
                case "Normal":
                    price = 249.99;
                    break;
            }

            if (peopleCount >= 1 && peopleCount < 5)
                moneyLeft -= budget * 0.75;
            else if (peopleCount >= 5 && peopleCount < 10)
                moneyLeft -= budget * 0.60;
            else if (peopleCount >= 10 && peopleCount < 25)
                moneyLeft -= budget * 0.50;
            else if (peopleCount >= 25 && peopleCount < 50)
                moneyLeft -= budget * 0.40;
            else
                moneyLeft -= budget * 0.25;

            double moneyNeeded = peopleCount * price;

            if(moneyLeft > moneyNeeded)
                Console.WriteLine("Yes! You have {0:F2} leva left.", (moneyLeft - moneyNeeded));
            else
                Console.WriteLine("Not enough money! You need {0:F2} leva.", (moneyNeeded - moneyLeft));

        } 
    }
}
