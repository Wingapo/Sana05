namespace Main
{
    internal class MyDate
    {
        public int Year { set; get; }
        public byte Month { set; get; }
        public byte Day { set; get; }  
        public byte Hours { set; get; }
        public byte Minutes { set; get; }

        public MyDate()
        {
        }

        public MyDate(int year, byte month, byte day, byte hours, byte minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public MyDate(byte day, byte hours, byte minutes)
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
    }
}
