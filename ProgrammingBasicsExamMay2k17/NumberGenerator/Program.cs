using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());


            for (int i = first; i >= 1; i--)
            {
                for (int j = second; j >= 1; j--)
                {
                    for (int k = three; k >= 1; k--)
                    {
                        int number = i * 100 + j * 10 + k;
                        if (number % 3 == 0)
                        {
                            special += 5;
                        }
                        else if (number % 5 == 0)
                        {
                            special -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            special *= 2;
                        }

                    }

                    if (special >= controlNumber)
                    {
                        Console.WriteLine("Yes! Control number was reached! Current special number is {0}", special);
                        
                    }
                }
            }
           if(special < controlNumber)
            {
                Console.WriteLine("No! {0} is the last reached special number.", special);
            }

        }
         
        } }
    

