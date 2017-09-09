using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;

            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            if (hours >= 24)
                hours -= 24;

            if (minutes < 10)
                Console.WriteLine("{0}:0{1}", hours, minutes);
            else
                Console.WriteLine("{0}:{1}", hours, minutes);


        }
    }
}
