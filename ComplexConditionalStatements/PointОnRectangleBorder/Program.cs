using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double xInput = Math.Abs(double.Parse(Console.ReadLine()));
            double yInput = Math.Abs(double.Parse(Console.ReadLine()));

            if (((xInput == x1 || xInput == x2) && (yInput >= y1 && yInput <= y2)) 
             || ((yInput == y1 || yInput == y2) && (xInput >= x1 && xInput <= x2)))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
