namespace Main
{
    internal class Airplane
    {
        public string StartCity { set; get; }
        public string FinishCity { set; get; }
        public MyDate StartDate { set; get; }
        public MyDate FinishDate { set; get;}

        public Airplane()
        {
            StartCity = "";
            FinishCity = "";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(MyDate startDate, MyDate finishDate)
        {
            StartCity = "";
            FinishCity = "";
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public int GetTotalTime()
        {
            int months = FinishDate.Month - StartDate.Month;
            if (months < 0) months += 12;

            int days = FinishDate.Day - StartDate.Day;
            int hours = FinishDate.Hours - StartDate.Hours;
            int minutes = FinishDate.Minutes - StartDate.Minutes;

            return (months * MyDate.DaysInMonth(StartDate.Month) + days) * 1440 + hours * 60 + minutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year &&
                StartDate.Month == FinishDate.Month &&
                StartDate.Day == FinishDate.Day;
        }
    }
}
