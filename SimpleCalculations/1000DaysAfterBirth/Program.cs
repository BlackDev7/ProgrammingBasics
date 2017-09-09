using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null); ;
            DateTime birthAfter100 = birthDate.AddDays(999);
            string dateFormat = "dd-MM-yyyy";
            string strDate = birthAfter100.ToString(dateFormat);

            Console.WriteLine(strDate);
        }
    }
}
