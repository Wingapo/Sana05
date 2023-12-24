namespace Main
{
    internal class Airplane
    {
        public string StartCity {protected set; get; }
        public string FinishCity {protected set; get; }
        public MyDate StartDate {protected set; get; }
        public MyDate FinishDate {protected set; get;}

        public Airplane()
        {
            StartCity = "";
            FinishCity = "";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(MyDate startDate, MyDate finishDate)
        {
            StartCity = "";
            FinishCity = "";
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Airplane other)
        {
            StartCity = other.StartCity;
            FinishCity = other.FinishCity;
            StartDate = other.StartDate;
            FinishDate = other.FinishDate;
        }

        public int GetTotalTime()
        {
            int months = FinishDate.Month - StartDate.Month;
            if (months < 0) months += 12;

            int days = FinishDate.Day - StartDate.Day;
            int hours = FinishDate.Hours - StartDate.Hours;
            int minutes = FinishDate.Minutes - StartDate.Minutes;

            return (months * MyDate.DaysInMonth(StartDate.Month) + days) *
                1440 + hours * 60 + minutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year &&
                StartDate.Month == FinishDate.Month &&
                StartDate.Day == FinishDate.Day;
        }
    }
}
