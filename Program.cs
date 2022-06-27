using System;
using System.Collections.Generic;
using System.Linq;
using Telephony.Models;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {

            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();



            List<String> phoneNumbersToCall = line1.Split(" ").ToList();
            List<String> sitesToVisit = line2.Split(" ").ToList();
           

            for (int i = 0; i < phoneNumbersToCall.Count; i++)
            {
                if (phoneNumbersToCall[i].Length == 10)
                {
                    Smartphone smartphone = new Smartphone(); 
                    Console.WriteLine(smartphone.Call(phoneNumbersToCall[i]));
                }


                else
                {
                    StationaryPhone stationaryPhone = new StationaryPhone();
                    Console.WriteLine(stationaryPhone.Call(phoneNumbersToCall[i]));

                }

            }
            foreach (var site in sitesToVisit)
            {
                Smartphone smartphone = new Smartphone();
                Console.WriteLine(smartphone.Browse(site));
            }

        }
    }
}
