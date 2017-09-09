using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNurmal = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfWeekendsAtHomeTown = int.Parse(Console.ReadLine());
            int weekendsAtSofia = (48 - numberOfWeekendsAtHomeTown);
            double numbeOfTrainingsSofia = (weekendsAtSofia * (3.0 / 4));
            double numberOfTrainingsSofiaHolidays = (numberOfHolidays * ( 2.0 / 3));
            double totalNumberOfTraningsSofia = numbeOfTrainingsSofia + numberOfWeekendsAtHomeTown + numberOfTrainingsSofiaHolidays;

            if (leapOrNurmal.Equals("leap"))
            {
                totalNumberOfTraningsSofia += ((totalNumberOfTraningsSofia / 100) * 15);
            }
            Console.WriteLine(Math.Floor(totalNumberOfTraningsSofia) );
        }
    }
}
