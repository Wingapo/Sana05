namespace Main
{
    internal class MyDate
    {
        public int Year {protected set; get; }
        public sbyte Month {protected set; get; }
        public sbyte Day {protected set; get; }  
        public sbyte Hours {protected set; get; }
        public sbyte Minutes {protected set; get; }

        public MyDate()
        {
        }

        public MyDate(int year, sbyte month, sbyte day, sbyte hours, sbyte minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public MyDate(sbyte day, sbyte hours, sbyte minutes)
        {
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public MyDate(MyDate other)
        {
            Year = other.Year;
            Month = other.Month;
            Day = other.Day;
            Hours = other.Hours;
            Minutes = other.Minutes;
        }

        public static byte DaysInMonth(int month)
        {
            if(month == 2) return 28;

            if (month > 7) month -= 7;

            if (month % 2 == 0) return 30;
            else return 31;
        }
    }
}
