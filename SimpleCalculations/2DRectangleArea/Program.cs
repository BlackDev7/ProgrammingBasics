using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double z1 = Math.Abs(x1 - x2);
            double z2 = Math.Abs(y2 - y1);

            double area = z1 * z2;
            double perimeter = 2 * (z1 + z2);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
