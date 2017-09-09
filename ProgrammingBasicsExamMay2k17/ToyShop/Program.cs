using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double talkingDollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;

            double holidayPrice = double.Parse(Console.ReadLine());
            double puzzleQuantity = double.Parse(Console.ReadLine());
            double talkingDollQuantity = double.Parse(Console.ReadLine());
            double bearQuantity = double.Parse(Console.ReadLine());
            double minionQuantity = double.Parse(Console.ReadLine());
            double truckQuantity = double.Parse(Console.ReadLine());

            double sumQuantity = (puzzleQuantity + talkingDollQuantity + bearQuantity + minionQuantity + truckQuantity);
            double sumPrice = (puzzleQuantity * puzzlePrice) + (bearPrice * bearQuantity) + (minionPrice * minionQuantity) + (truckPrice * truckQuantity) + (talkingDollPrice* talkingDollQuantity);
           // Console.WriteLine("Sum Quantity: {0}, sumPrice: {1}, ", sumQuantity, sumPrice);
            if (sumQuantity >= 50)
            {
                sumPrice = (sumPrice / 100) * 75;
            }
            sumPrice -= ((sumPrice/100) * 10);
            if(sumPrice >= holidayPrice)
            {
                double moneyLeft = (sumPrice - holidayPrice);
                Console.WriteLine("Yes! {0} lv left.", moneyLeft.ToString("0.00"));
            }
            else
            {
                double moneyNeeded = (holidayPrice - sumPrice);
                Console.WriteLine("Not enough money! {0} lv needed.", moneyNeeded.ToString("0.00"));
            }
            //Console.WriteLine("SumPriceAfter: {0} ", sumPrice);

        }
    }
}
