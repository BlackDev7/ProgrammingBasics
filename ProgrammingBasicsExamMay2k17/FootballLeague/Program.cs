using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacityOfStadium = double.Parse(Console.ReadLine());
            double amountOfAllFans = double.Parse(Console.ReadLine());
            double amountOfPeopleInASector = 0;
            double amountOfPeopleInBSector = 0;
            double amountOfPeopleInVSector = 0;
            double amountOfPeopleInGSector = 0;
            for (int i = 1; i <= amountOfAllFans; i++)
            {
                string sectorHesIn = Console.ReadLine();
                switch(sectorHesIn)
                {
                    case "A":
                        amountOfPeopleInASector++;
                        break;
                    case "B":
                        amountOfPeopleInBSector++;
                        break;
                    case "V":
                        amountOfPeopleInVSector++;
                        break;
                    case "G":
                        amountOfPeopleInGSector++;
                        break;
                }
            }
            double percentageOfPeopleInASector = ((amountOfPeopleInASector / amountOfAllFans) * 100);
            double percentageOfPeopleInBSector = ((amountOfPeopleInBSector / amountOfAllFans) * 100);
            double percentageOfPeopleInVSector = ((amountOfPeopleInVSector / amountOfAllFans) * 100);
            double percentageOfPeopleInGSector = ((amountOfPeopleInGSector / amountOfAllFans) * 100);
            double percentageOfCapacity = ((amountOfAllFans / capacityOfStadium) * 100);
            Console.WriteLine("{0}%", percentageOfPeopleInASector.ToString("0.00"));
            Console.WriteLine("{0}%", percentageOfPeopleInBSector.ToString("0.00"));
            Console.WriteLine("{0}%", percentageOfPeopleInVSector.ToString("0.00"));
            Console.WriteLine("{0}%", percentageOfPeopleInGSector.ToString("0.00"));
            Console.WriteLine("{0}%", percentageOfCapacity.ToString("0.00"));
        }
    }
}
