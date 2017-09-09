using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            double x1First = 0;
            double y1First = 0;
            double x2First = 3 * h;
            double y2First = h; ;
            double x1Second = h;
            double y1Second = 0;
            double x2Second = h * 2;
            double y2Second = 4 * h;
            double xInput = double.Parse(Console.ReadLine());
            double yInput = double.Parse(Console.ReadLine());

            bool isWithinFirstFigure = false;
            bool isWithinSecondFigure = false;


            if ((xInput >= x1First) && (xInput <= x2First) && (yInput >= y1First) && (yInput <= y2First))
                isWithinFirstFigure = true;

            else if ((xInput >= x1Second) && (xInput <= x2Second) && (yInput >= y1Second) && (yInput <= y2Second))
                isWithinFirstFigure = true;

            if (isWithinFirstFigure || isWithinSecondFigure)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }

        }
    }
}
