using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication8.CustomExtensions;

namespace WebApplication8.CustomExtensions
{
    public static class DateTimeExtention
    {

        public static int ToAge(this DateTime birthDate)
        {
            return ToAge(birthDate, DateTime.Today);
        }

        public static int ToAge(this DateTime birthDate, DateTime laterDate)
        {
            int age;
            age = laterDate.Year - birthDate.Year;

            if (age > 0)
            {
                age -= Convert.ToInt32(laterDate.Date < birthDate.Date.AddYears(age));
            }
            else
            {
                age = 0;
            }

            return age;
        }
    }
}

class Extention
{
    static void Main(string[] args)
    {
        RunTest();
    }

    private static void RunTest()
    {
        DateTime birthDate = new DateTime(1990, 01, 01);
        DateTime laterDate = new DateTime(2018,10,26);
        string Day = "yyyy-MM-dd";

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Birth date: " + birthDate.AddDays(i).ToString(Day) + "  Later date: " + laterDate.AddDays(j).ToString(Day) + "  Age: " + birthDate.AddDays(i).ToAge(laterDate.AddDays(j)).ToString());
            }
        }

        Console.ReadKey();
    }
}


