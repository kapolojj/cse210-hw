using System;

class Program
{
    static void Main(string[] args)
    {
        Car myCarObject = new Car();
        var CarName = myCarObject.CarName();

        Car2 myCarObject2 = new Car2();
        var CarName2 = myCarObject2.CarName2();

        // total = CarName + CarName2

        Console.WriteLine($"{CarName + CarName2}");
    }
}