using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoinQuantity = double.Parse(Console.ReadLine());
            double chineseQuantity = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitcoinInBgn = bitcoinQuantity * 1168.00;
            double chineseInBgn = (chineseQuantity * 0.15) * 1.76;
            double sumInBgn = bitcoinInBgn + chineseInBgn;
            double euros = sumInBgn / 1.95;

            Console.WriteLine((euros - ((euros/100) * commision)).ToString("0.00"));

        }
    }
}
