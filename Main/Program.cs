using Main;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        //Airplane airplane = new Airplane("a", "b", new MyDate(2001,12,31,10,20), new MyDate(2001,1,1,8,10));
        Airplane airplane = new Airplane("a", "b", new MyDate(2001,1,1,8,00), new MyDate(2001,1,1,20,00));
        Console.WriteLine(airplane.GetTotalTime());
        Console.WriteLine(airplane.IsArrivingToday());

    }
}