using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if(figure.Equals("square"))
            {
               decimal squareA =  decimal.Parse(Console.ReadLine());
                decimal squareArea = squareA * squareA;
                Console.WriteLine(squareArea);
            }
            else if(figure.Equals("rectangle"))
            {
                decimal rectangleA = decimal.Parse(Console.ReadLine());
                decimal rectangleB = decimal.Parse(Console.ReadLine());
                decimal rectangleArea = rectangleA * rectangleB;
                Console.WriteLine(rectangleArea);
            }
            else if (figure.Equals("circle"))
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * (circleRadius * circleRadius);
                Console.WriteLine(circleArea);
            }
            else if (figure.Equals("triangle"))
            {
                double triangleA = double.Parse(Console.ReadLine());
                double triangleH = double.Parse(Console.ReadLine());
                double triangleArea = ((triangleA * triangleH) / 2);
                Console.WriteLine(triangleArea);
            }
        }
    }
}
