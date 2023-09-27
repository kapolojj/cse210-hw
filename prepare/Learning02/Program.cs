using System;

class Program
{
    static void Main(string[] args)
    {
        car sportsCarobject = new car ();
        car vanCarobject = new car();

        var carName = sportsCarobject.CarName("Lembo");
        var vanName = vanCarobject.CarName("Ford");

        Console.WriteLine(carName);
        Console.WriteLine(vanName);
    }
}