using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            switch(city)
            {
                case "Sofia":
                    if(volume >= 0  && volume <= 500)
                    {
                        Console.WriteLine("{0:f2}",(volume/100) * 5, 2);
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 7, 2);
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 8, 2);
                    }
                    else if( volume > 10000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 12, 2);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (volume >= 0 && volume <= 500)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 4.5, 2);
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        Console.WriteLine("{0:f2}", (volume / 100) * 7.5, 2);
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 10, 2);
                    }
                    else if (volume > 10000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 13, 2);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (volume >= 0 && volume <= 500)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 5.5, 2);
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 8, 2);
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 12, 2);
                    }
                    else if (volume > 10000)
                    {
                        Console.WriteLine("{0:f2}",(volume / 100) * 14.5, 2);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
