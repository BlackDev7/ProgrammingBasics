using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAsterisks = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= ((n + 1) / 2); i++)
            {
                
                if((n % 2 == 0) && (i == 1))
                {
                    string slash = new string('-', (n - 2) / 2);
                    Console.WriteLine("{0}**{0}", slash);
                    currentAsterisks += 2;
                }
                else if((n % 2 != 0) && (i == 1))
                {
                    string slash = new string('-', (n - 1) / 2);;
                    Console.WriteLine("{0}*{0}", slash);
                    currentAsterisks += 1;
                }
                else
                {
                    currentAsterisks += 2;
                    string slash = new string('-', (n - currentAsterisks) / 2);
                    string asterisks = new string('*', currentAsterisks);
                    Console.WriteLine("{0}{1}{0}", slash, asterisks);
                }
            }
            for(int i = 1; i <= ((n / 2) ); i++)
            {
                if ((n % 2 == 0))
                {
                    string asterisks = new string('*', (n - 2));
                    Console.WriteLine("|{0}|", asterisks);
                }
                else
                {
                    string asterisks = new string('*', (n - 2));
                    Console.WriteLine("|{0}|", asterisks);
                }
                    
            }
        }
    }
}
