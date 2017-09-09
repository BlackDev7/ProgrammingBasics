using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctorsCount = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int patientsThisDay = 0;
            for(int i = 1; i <= period; i++)
            {
                if (i % 3 == 0 && (untreatedPatients > treatedPatients))
                    doctorsCount++;

                patientsThisDay = int.Parse(Console.ReadLine());
                treatedPatients += (patientsThisDay - doctorsCount);
                if (patientsThisDay > doctorsCount)
                    untreatedPatients = patientsThisDay - treatedPatients;
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);

        }
    }
}
