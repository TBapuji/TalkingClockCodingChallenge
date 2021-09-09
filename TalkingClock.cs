using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TalkingClockCodingChallenge
{
    public class TalkingClock
    {
        //private string _time = String.Empty;
        private static string[] hours = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
        //TODO:  Could refactor and remove around half of these over thirty
        private static string[] minutes = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
        "thirteen", "fourteen", "quarter", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four",
        "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine", "thirty", "thirty one","thirty two","thirty three","thirty four", "thirty five", "thirty six",
        "thirty seven", "thirty eight", "thirty nine", "forty", "forty one","forty two","forty three", "forty four", "quarter", "forty six", "forty seven",
        "forty eight", "forty nine", "fifty", "fifty one", "fifty two", "fifty three", "fifty four", "fifty five", "fifty six", "fifty seven", "fifty eight", "fifty nine"};
        //public TalkingClock()
        //{
        //}

        public static string Time(string time)
        {
            DateTime dateTime;
            if(CorrectFormat(time, out dateTime))
            {
                if(MoreThanHalfPast(dateTime.Minute)) { dateTime.AddHours(1); } // e.g. 14:35 is twenty five to THREE (not TWO)
                string hours = GetSpokenHours(dateTime.Hour);
                string minutes = GetSpokenMinutes(dateTime.Minute);
                string spokenSpeechPart = GetSpokenSpeechPart(dateTime);
                return GetSpokenTime(dateTime);
            }
            else 
            { 
                return "faile"; 
            }
        }
        private static bool CorrectFormat(string time, out DateTime dateTime)
        {
            //This checks if the time entered is valid
            string formatSingleHourDigit = "H:mm";    //24 hour formats
            string formatDoubleHourDigit = "HH:mm";
            //DateTime dateTime;

            return (DateTime.TryParseExact(time, formatSingleHourDigit, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime)
                   || DateTime.TryParseExact(time, formatDoubleHourDigit, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime));
        }
        private static string GetSpokenHours(int hourNumber)
        { 
            if (hourNumber >12) { hourNumber -= 12; }   // since e.g. 14:00 is two o'clock and not fourteen o'clock
            for(int i=0;i<hours.Length;i++)
            {
                if(hourNumber-1==i)
                return hours[i];

            }
            throw new Exception("Spoken hours not found");
            //return "";
        }
        private static bool MoreThanHalfPast(int minuteNumber)
        {
            if(minuteNumber > 30) { return true; }
            else { return false; }
        }
        private static string GetSpokenMinutes(int minuteNumber)
        {
            if(minuteNumber > 30) { minuteNumber = 60 - minuteNumber; } // since e.g. 14:00 is two o'clock and not fourteen o'clock
            for(int i = 0; i < minutes.Length; i++)
            {
                if(minuteNumber - 1 == i)
                // could have the function as bool and set value to private property...
                    return minutes[i];

            }
            throw new Exception("Spoken minutes not found");
            //return "";
        }
        private static string GetSpokenSpeechPart(DateTime dateTime)
        {
            string spokenSpeechPart = String.Empty;
            if(dateTime.Minute == 00) { spokenSpeechPart = "o'clock"; }
            else if(dateTime.Minute > 00 && dateTime.Minute < 30) { spokenSpeechPart = "past"; }
            else if(dateTime.Minute == 30) { spokenSpeechPart = "half past"; }
            else if(dateTime.Minute > 30 && dateTime.Minute < 60) { spokenSpeechPart = "to"; }
            return spokenSpeechPart;
        }

        private static string GetSpokenTime(DateTime dateTime)
        {
            return $"";
        }
        private static string CapitaliseFirstLetter(string time)
        {
            
            return time;
        }
    }
}
