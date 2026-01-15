using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // int num = 96;
        // int ones = 0;

        // ones = num % 10;
        // Console.Write(ones);

        // Used for error handling. Programs in a "safe" response to an error


        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator/denominator;
        }
        catch (Exception e)
        {
            Console.WriteLine("Ope, something happened.");
            Console.WriteLine(e.ToString());    // Prints the error message to the console.
        }
    }
}