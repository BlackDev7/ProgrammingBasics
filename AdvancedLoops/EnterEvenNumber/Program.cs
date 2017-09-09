using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numberInput))
                {
                    if((numberInput % 2) == 0)
                    {

                        Console.WriteLine("Even number entered: {0}", numberInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
