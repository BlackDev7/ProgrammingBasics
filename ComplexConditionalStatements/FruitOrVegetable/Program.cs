using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegetables = { "tomato", "cucumber", "pepper", "carrot"};

            if (fruits.Any(product.Contains))
            {
                Console.WriteLine("fruit");
            }
            else if(vegetables.Any(product.Contains))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
