using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int columnsCount = int.Parse(Console.ReadLine());

            switch(projectionType)
            {
                case "Premiere":
                    Console.WriteLine("{0:f2}", rowsCount * columnsCount * 12.00);
                    break;
                case "Normal":
                    Console.WriteLine("{0:f2}", rowsCount * columnsCount * 7.50);
                    break;
                case "Discount":
                    Console.WriteLine("{0:f2}", rowsCount * columnsCount * 5.00);
                    break;
                default:
                    Console.WriteLine("error");
                    break;

        }
    }
}
