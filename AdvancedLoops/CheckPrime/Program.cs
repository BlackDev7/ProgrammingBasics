﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n <= 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for(int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
                {
                    if(n % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                    }
                    else
                    {
                        Console.WriteLine("Prime");
                    }
                }
            }
        }
    }
}
