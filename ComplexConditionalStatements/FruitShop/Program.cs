﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if(weekDays.Any(dayOfWeek.Contains))
            {
                switch (dayOfWeek)
                {
                    case "Saturday":
                    case "Sunday":
                        switch(fruit)
                        {
                            case "banana":
                                Console.WriteLine(quantity * 2.70);
                                break;
                            case "apple":
                                Console.WriteLine(quantity * 1.25);
                                break;
                            case "orange":
                                Console.WriteLine(quantity * 0.90);
                                break;
                            case "grapefruit":
                                Console.WriteLine(quantity * 1.60);
                                break;
                            case "kiwi":
                                Console.WriteLine(quantity * 3.00);
                                break;
                            case "pineapple":
                                Console.WriteLine(quantity * 5.60);
                                break;
                            case "grapes":
                                Console.WriteLine(quantity * 4.20);
                                break;
                            default:
                                Console.WriteLine("Fruit doesn't exist");
                                break;
                        }
                        break;
                    default:
                        switch (fruit)
                        {
                            case "banana":
                                Console.WriteLine(quantity * 2.50);
                                break;
                            case "apple":
                                Console.WriteLine(quantity * 1.20);
                                break;
                            case "orange":
                                Console.WriteLine(quantity * 0.85);
                                break;
                            case "grapefruit":
                                Console.WriteLine(quantity * 1.45);
                                break;
                            case "kiwi":
                                Console.WriteLine(quantity * 2.70);
                                break;
                            case "pineapple":
                                Console.WriteLine(quantity * 5.50);
                                break;
                            case "grapes":
                                Console.WriteLine(quantity * 3.85);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
