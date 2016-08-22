using System;
using System.Collections;

namespace AlgorithmThousandBottlesAndTenRabbits
{
    public class InputHelper
    {
        public static ushort InputUshort()
        {
            ushort numUshort = 0;
            string s = Console.ReadLine();
            bool canConvert = false;
            while (canConvert == false)
            {
                if (ushort.TryParse(s, out numUshort))
                {
                    canConvert = true;
                }
                else
                {
                    Console.WriteLine("Incorrect Ushort, try again:");
                    break;
                }
            }
            return numUshort;
        }

        public static ushort InputBottleNumber()
        {
            ushort numBottle = 0;
            numBottle = InputUshort();

            bool result = false;
            while (result == false)
            {
                if (numBottle > 0 && numBottle <= 1000)
                {
                    Console.WriteLine("Poisoned bottle's number = " + numBottle);
                    result = true;
                }
                else
                {
                    Console.WriteLine("Error, Algorithm work for botte's number from 1 to 1000. Please, try again:");
                    InputBottleNumber();
                    break;
                }
            }

            return numBottle;
        }

        public static ushort InputPoisonedRabbit()
        {
            ushort numRabbit = InputUshort();

            bool result = false;
            while (result == false)
            {
                if (numRabbit > 0 && numRabbit <= 10)
                {
                    Console.WriteLine("Poisoned rabbit's number = " + numRabbit);
                    result = true;
                }
                else
                {
                    Console.WriteLine("Error, algorithm work only for rabbit's number from 1 to 10. Please, try again:");
                    InputPoisonedRabbit();
                    break;
                }
            }
            return numRabbit;
        }

        public static ArrayList GenerateRabbitsArray(ArrayList poisonedRabbitsArrayList = null)
        {
            ushort rabbitsQ = 10;
            poisonedRabbitsArrayList = new ArrayList();
            return null;
        }
    }
}