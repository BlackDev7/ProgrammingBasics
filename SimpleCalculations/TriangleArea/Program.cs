using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            decimal area = Math.Round(((a * h) / 2), 2);
            Console.WriteLine("Triangle area = {0}", area);

        }
    }
}
