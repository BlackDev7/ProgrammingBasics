using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.00 * nightsCount;
                    apartmentPrice = 65.00 * nightsCount;
                    if (nightsCount > 7 && nightsCount <= 14)
                        studioPrice *= 0.95;
                    else if (nightsCount > 14)
                        studioPrice *= 0.70;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20 * nightsCount;
                    apartmentPrice = 68.70 * nightsCount;
                    if (nightsCount > 14)
                        studioPrice *= 0.80;
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00 * nightsCount;
                    apartmentPrice = 77.00 * nightsCount;
                    break;
            }
            if (nightsCount > 14)
                apartmentPrice *= 0.90;


            Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apartmentPrice, studioPrice);
        }
    }
}
