using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmThousandBottlesAndTenRabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort n = 0;

            Console.WriteLine("Enter the number of the poisoned bottle: ");
            while (n == 0)
            {
                string s = Console.ReadLine();
                if (ushort.TryParse(s, out n) && n>0 )
                {
                    Console.WriteLine("Poisoned bottle's number = "+ n);
                    Console.WriteLine("Remember, by default, algorithm work for botte's number from 1 to 1000.");
                }
                else
                {
                    Console.WriteLine("Please, try again! Your number was invalid.");
                }
            }
            Console.WriteLine("Start algorithm processing...");
            Console.ReadLine();


        }
    }
}
