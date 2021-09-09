using System;
using System.Globalization;

namespace TalkingClockCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Talking Clock");
            Console.WriteLine("To get current time simply hit return.");
            Console.WriteLine();
            Console.WriteLine("To get user-defined time enter time and  hit return.");
            Console.WriteLine("(please use format h:mm or hh:mm, where h is hour and m is minute)");
            while (true)
            {
                string? t1 = Console.ReadLine();
                Console.WriteLine(TalkingClock.Time(t1));
                //if("Q" == Console.ReadLine()) break;
            }
            //Console.ReadLine();
        }
    }
}
