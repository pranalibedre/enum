using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    public enum Season
    {
        Summer,
        Winter,
        Rainy
    };
    public enum Month
    {
        jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec
    };
    class Program
    {
        public Month month { get; set; }
        public Season season { get; set; }
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {
            //Days d = Days.thu ;
            //int WeekdayStart = (int)Days.Mon;
            //int WeekdayEnd = (int)Days.Fri;
            //Console.WriteLine((int)d);
            //Console.WriteLine("Monday: {0}", WeekdayStart);
            //Console.WriteLine("Friday: {0}", WeekdayEnd);
            //Console.ReadKey();

            Program[] weather = new Program[3];

            weather[0] = new Program
            {
                season = Season.Summer,
                month = Month.mar
            };
            weather[1] = new Program
            {
                season = Season.Rainy,
                month = Month.aug
            };
            weather[2] = new Program
            {
                season = Season.Winter,
                month = Month.nov
            };
            foreach (Program a in weather)
            {
                Console.WriteLine(" month is {0} and season is {1}", a.month, GetSeason((a.season)));
             
            }
            Console.Read();
        }
        public static string GetSeason(Season season)
        {
            switch (season)
            {
                case Season.Summer:
                    return "Summer";
                case Season.Rainy:
                    return "Rainy";
                case Season.Winter:
                    return "Winter";
                default:
                    return "invalid entry";
            }
        }
    }
    //public class Weather
    //{
    //    public Month month { get; set; }
    //    public Season season { get; set; }
    //}
}
