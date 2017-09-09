using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal whiskeyPrice = decimal.Parse(Console.ReadLine());
            decimal beerQuantity = decimal.Parse(Console.ReadLine());
            decimal wineQuantity = decimal.Parse(Console.ReadLine());
            decimal rakijaQuantity = decimal.Parse(Console.ReadLine());
            decimal whiskeyQuantity = decimal.Parse(Console.ReadLine());
            decimal rakijaPrice = (whiskeyPrice / 2);
            decimal beerPrice = (rakijaPrice / 100) * 20;
            decimal winePrice = (rakijaPrice / 100) * 60;

            decimal priceSum = (whiskeyPrice * whiskeyQuantity) + (beerQuantity * beerPrice) + (wineQuantity * winePrice) + (rakijaQuantity * rakijaPrice);
            Console.WriteLine(priceSum.ToString("0.00"));
        }
    }
}
