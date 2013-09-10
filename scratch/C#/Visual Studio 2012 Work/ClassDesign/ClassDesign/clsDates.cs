using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsDates
    {
        // Symbolic Constants
        
        // Static Members
        private static int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        // Instance Members
        private int day;
        private int month;
        private int year;
        private int leapyear;
        private DateTime current;
        
        // Constructors
        public clsDates()
        {
            current = DateTime.Now;
        }

        public clsDates(int yr) : this()
        {
            year = yr;
        }

        // Property Methods

        // Helper Methods

        // General Methods
        public int getMonthDays(int month)
        {
            int days;
            if (month != 2)
            {
                days = daysInMonth[month];
            }
            else
            {
                days = daysInMonth[2] + getLeapYear(year);
            }
            return days;
        }


        public int getLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return 1;
            else
                return 0;
        }

        public string getEaster(int year)
        {
            int offset;
            int leap;
            int day;
            int temp1;
            int temp2;
            int total;

            offset = year % 19;
            leap = year % 4;
            day = year % 7;
            temp1 = (19 * offset + 24) % 30;
            temp2 = (2 * leap + 4 + day + 6 * temp1 + 5) % 7;
            total = (22 + temp1 + temp2);
            if (total > 31)
            {
                month = 4;
                day = total - 31;
            }
            else
            {
                month = 3;
                day = total;
            }
            DateTime myDT = new DateTime(year, month, day);
            return myDT.ToLongDateString();
        }
    }