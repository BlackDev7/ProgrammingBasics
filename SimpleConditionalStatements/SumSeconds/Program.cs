using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int secondsWithoutMinutes = totalTime - (minutes * 60);
            if(secondsWithoutMinutes < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, secondsWithoutMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, secondsWithoutMinutes);
            }
           
        }
    }
}
