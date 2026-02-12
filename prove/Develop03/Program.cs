using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Word bork  = new Word();

        bork.SetWord();
        bork.DisplayWord();
        bork.Hide();
        bork.DisplayWord(); 
    }
        
}