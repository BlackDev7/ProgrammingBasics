using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordGuess = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            if(password.Equals(passwordGuess))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
