using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{

    class Program
    {
        public  static double inputToM, convertedUnit;
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            switch (inputUnit)
            {
                case "mm":
                    inputToM = number / 1000;
                    break;
                case "cm":
                    inputToM = number / 100;
                    break;
                case "m":
                    inputToM = number;
                    break;
                case "mi":
                    inputToM = number / 0.000621371192;
                    break;
                case "in":
                    inputToM = number / 39.3700787;
                    break;
                case "km":
                    inputToM = number / 0.001;
                    break;
                case "ft":
                    inputToM = number / 3.2808399;
                    break;
                case "yd":
                    inputToM = number / 1.0936133;
                    break;
                default:
                    Console.WriteLine("Input Unit is invalid");
                    break;
            }

            switch (outputUnit)
            {
                case "mm":
                    convertedUnit = inputToM * 1000;
                    break;
                case "cm":
                    convertedUnit = inputToM * 100;
                    break;
                case "m":
                    convertedUnit = inputToM;
                    break;
                case "mi":
                    convertedUnit = inputToM * 0.000621371192;
                    break;
                case "in":
                    convertedUnit = inputToM * 39.3700787;
                    break;
                case "km":
                    convertedUnit = inputToM * 0.001;
                    break;
                case "ft":
                    convertedUnit = inputToM * 3.2808399;
                    break;
                case "yd":
                    convertedUnit = inputToM * 1.0936133;
                    break;
                default:
                    Console.WriteLine("Something went wrong while converting");
                    break;
            }
            Console.WriteLine("{0} {1}", convertedUnit, outputUnit);

        }
    }
    
}
