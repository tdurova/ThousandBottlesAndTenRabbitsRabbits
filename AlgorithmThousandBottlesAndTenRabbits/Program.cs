using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmThousandBottlesAndTenRabbits
{
    class Program
    {
        private static void SearchPoisonedRabbits(ushort n = 0)
        {
            Console.WriteLine("Inverse problem, search poisoned rabbits with known poisoned bottle. ");
            Console.WriteLine("Enter the number of the poisoned bottle: ");
            while (n == 0)
            {
                string s = Console.ReadLine();
                if (ushort.TryParse(s, out n) && n > 0)
                {
                    Console.WriteLine("Poisoned bottle's number = " + n);
                    Console.WriteLine("Remember, by default, algorithm work for botte's number from 1 to 1000.");
                }
                else
                {
                    Console.WriteLine("Please, try again! Your number was invalid.");
                }
            }
            Console.ReadLine();
        }

        private static void SearchPoisonedBottleNumber(bool[] rabbits = null)
        {
            rabbits = new bool[10];

            Console.WriteLine("Direct problem, search poisoned bottle with known poisoned tabbits. ");
            Console.WriteLine("Enter the numbers of the poisoned rabbits: ");
            string s = Console.ReadLine();
            string[] poisonedRabbits = s?.Split(',');

            foreach (string str in poisonedRabbits)
            {
                byte oneNum;
                if (Byte.TryParse(str, out oneNum))
                {
                    rabbits[oneNum] = true;
                }
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            SearchPoisonedRabbits();
            SearchPoisonedBottleNumber(new byte[] {1, 3, 5, 7, 9});
        }
    }
}
