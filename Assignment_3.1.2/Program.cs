/*
 2. If year is leap
Given a year as integer, write a method that checks if year is leap.
Expected input and output
IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
*/

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Assignment_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2018;
            DateTime.IsLeapYear(year);

            if (DateTime.IsLeapYear(year) == true)
            {
                Console.WriteLine($"True, {year} is a leap year");
            }
            else
            {
                Console.WriteLine($"False, {year} is not a leap year");
            }
            Console.WriteLine("Record checked on: " + DateTime.Now);
        }           

    }
}
