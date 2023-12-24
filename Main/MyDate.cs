namespace Main
{
    internal class MyDate
    {
        public int Year { set; get; }
        public sbyte Month { set; get; }
        public sbyte Day { set; get; }  
        public sbyte Hours { set; get; }
        public sbyte Minutes { set; get; }

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

        public MyDate(MyDate date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
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
