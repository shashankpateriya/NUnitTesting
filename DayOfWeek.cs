using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class DayOfWeek
    {
        public static void ReadInput()
        {
            //Get the input from user
            Console.WriteLine("Enter the date : ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the year : ");
            int y = Convert.ToInt32(Console.ReadLine());
            FindDayOfWeek(d, m, y);

        }

        public static void FindDayOfWeek(int d, int m, int y)
        {
            //array initialization and declaration
            string[] day = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //Calculating the day of week
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("The day" + " " + d + m + y + " " + "falls on" + " " + day[d0]);
        }
    }
}