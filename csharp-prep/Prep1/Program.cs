using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.\n");

        Car c1 = new Car();
        c1._make = "Honda";
        c1._model = "Accord";
        c1._year = 1995;
    }
}