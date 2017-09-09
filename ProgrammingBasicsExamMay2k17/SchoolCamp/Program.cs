using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;
            string sport = "";
            switch (season)
            {
                case "Winter":
                    switch (groupType)
                    {
                        case "boys":
                            moneyNeeded = studentsCount * 9.60 * nightsCount;
                            sport = "Judo";
                            break;
                        case "girls":
                            moneyNeeded = studentsCount * 9.60 * nightsCount;
                            sport = "Gymnastics";
                            break;
                        case "mixed":
                            moneyNeeded = studentsCount * 10 * nightsCount;
                            sport = "Ski";
                            break;
                    }
                    break;
                case "Spring":
                    switch (groupType)
                    {
                        case "boys":
                            moneyNeeded = studentsCount * 7.20 * nightsCount;
                            sport = "Tennis";
                            break;
                        case "girls":
                            moneyNeeded = studentsCount * 7.20 * nightsCount;
                            sport = "Athletics";
                            break;
                        case "mixed":
                            moneyNeeded = studentsCount * 9.50 * nightsCount;
                            sport = "Cycling";
                            break;
                    }
                    break;
                case "Summer":
                    switch (groupType)
                    {
                        case "boys":
                            moneyNeeded = studentsCount * 15 * nightsCount;
                            sport = "Football";
                            break;
                        case "girls":
                            moneyNeeded = studentsCount * 15 * nightsCount;
                            sport = "Volleyball";
                            break;
                        case "mixed":
                            moneyNeeded = studentsCount * 20 * nightsCount;
                            sport = "Swimming";
                            break;
                    }
                    break;
            }
            if (studentsCount >= 50)
                moneyNeeded = moneyNeeded / 2;
            else if(studentsCount >= 20 && studentsCount <= 50)
                moneyNeeded = (moneyNeeded / 100) * 85;
            else if (studentsCount >= 10 && studentsCount <= 20)
                moneyNeeded = (moneyNeeded / 100) * 95;

            Console.WriteLine("{0} {1} lv.", sport, moneyNeeded.ToString("0.00"));
        }
    }
}
