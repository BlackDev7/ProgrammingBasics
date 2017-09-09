using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double xSquareMeters = double.Parse(Console.ReadLine());
            double yGrapesSquareMeters = double.Parse(Console.ReadLine());
            double zWineNeeded = double.Parse(Console.ReadLine());
            double workersCount = double.Parse(Console.ReadLine());

            double totalGrape = yGrapesSquareMeters * xSquareMeters * 0.4;
            double wine = (totalGrape / 2.5);
         
            if(wine < zWineNeeded)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(zWineNeeded - wine));
            }
            else
            {
                double wineLeft = wine - zWineNeeded;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling((wineLeft / workersCount)));

                
            }
        }
    }
}
