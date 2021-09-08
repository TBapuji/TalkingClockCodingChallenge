using System;

namespace TalkingClockCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time for talking clock");
            string time = Console.ReadLine();
            Console.WriteLine(TalkingClock.Time(time));
            Console.ReadLine();
        }
    }
}
