using System;
using System.Globalization;

namespace TalkingClockCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string instruction = "Please use format h:mm or hh:mm, where h is hour and m is minute.";
            Console.WriteLine("Talking Clock");
            Console.WriteLine("To get current time simply hit return.");
            Console.WriteLine("To get user-defined time enter time and  hit return.");
            Console.WriteLine($"{instruction}");
            while(true)
            {
                try
                {
                    string? t1 = Console.ReadLine();
                    Console.WriteLine(TalkingClock.Time(t1));
                    //if("Q" == Console.ReadLine()) break;}
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{instruction}");
                }
                //Console.ReadLine();
            }
        }
    }
}
