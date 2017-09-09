using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysFirmHas = int.Parse(Console.ReadLine());
            int workersExtraordinaryCount = int.Parse(Console.ReadLine());

            double workingHours = daysFirmHas * 0.9 * 8;
            double extraordinaryHours = workersExtraordinaryCount * (daysFirmHas * 2);
            double totalHours = workingHours + extraordinaryHours;

            if(totalHours >= hoursNeeded)
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(totalHours - hoursNeeded));
            else
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(Math.Floor(totalHours - hoursNeeded)));
        }
    }
}
