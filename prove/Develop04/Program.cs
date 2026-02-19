using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Develop04 World!");

        Motorcycle m = new Motorcycle("Monkey", 2, "500cc");

        Console.WriteLine($"{m.GetEngineType()}\n");
    }
}