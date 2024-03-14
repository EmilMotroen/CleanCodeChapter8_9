using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class SerialDate
    {

        private int day;
        private int month;
        private int year;

        private SerialDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public static SerialDate CreateInstance(int day, int month, int year)
        {
            return new SerialDate(day, month, year);
        }

        public static SerialDate AddMonths(int monthsToAdd, SerialDate date)
        {
            // You will need to implement this logic.
            // You should add the specified number of months to the date.
            // This may also change the year.
            // Also, ensure that the day of the month does not exceed the maximum for that month.
            return new SerialDate(date.GetDayOfMonth(), date.GetMonth() + monthsToAdd, date.GetYYYY());

        }

        public int GetDayOfMonth()
        {
            return this.day;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public int GetYYYY()
        {
            return this.year;
        }
    }
}
