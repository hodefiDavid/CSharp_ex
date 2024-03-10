using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ex
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int getDay()
        {
            return day;
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public int getMonth()
        {
            return month;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public bool equals(Date other)
        {
            if (other == null)
            {
                return false;
            }
            if(day == other.day && month == other.month && year == other.year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override String ToString()
        {
            String res = "" + day + "/" + month + "/" + year;
            return res;
        }
    }

}
