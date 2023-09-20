// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning02 World!");
//     }
// }

// -----------------------------------------------------------


public class Person{
    public string _givenName = "";
    public string _familyName = "";
    public Person()
    {

    }
    public void ShowWesternName(){
        Console.WriteLine($"{_familyName},{_givenName}");
    }
    public void ShowEasternName(){
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}

