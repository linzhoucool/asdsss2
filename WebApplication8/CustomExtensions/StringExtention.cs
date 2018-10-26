using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApplication8.CustomExtensions
{
    public static class StringExtention
    {
        public static string digits()
        {
            string[] str = { "abc123", "z1x2c3v4", "#$ss223%^" };
            var result = str.ToDigitsOnly();
            foreach (var i in result)
            {
                Console.Write(i + "");
            }
            return digits;
        }
    }
}