// Use the below for testing

using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Develop03 World!\n");


        List<Scripture> scriptures = new List<Scripture>();
        Scripture sr = new Scripture("John", 3, 17, "For God so loved the world that he gave his only begotten son." );
        Scripture sr1 = new Scripture("John", 3, 17, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." );
        Scripture sr2 = new Scripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them." );
        Scripture sr3 = new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths." );
    
        scriptures.Add(sr);
        scriptures.Add(sr1);
        scriptures.Add(sr2);
        scriptures.Add(sr3);

        int count = 1;
        Console.Clear();
        foreach (Scripture scripture in scriptures)
        {
            Console.WriteLine($"{count} -> {scripture.GetScriptureReference()}");
            count++;
        }
        Console.WriteLine("Welcome to the scripture memorization tool.");
        Console.WriteLine("On which scripture do you wish to work? ");
        int selectedScripture = int.Parse(Console.ReadLine()) - 1;
        Debug.Assert(selectedScripture >= 0);
        Debug.Assert(selectedScripture < scriptures.Count);


        string input = "a";
        bool finished = false;
        while(input != "q" && !finished)
        {
            Console.Clear();
            Console.WriteLine("Enter 'q' to quit, press enter to remove words: ");

            scriptures[selectedScripture].ShowScripture();
            finished = scriptures[selectedScripture].HideSome_words();
            if(!finished)
            {
                input = Console.ReadLine();
            }
        }
    }
}



// using System;
// using System.Threading.Tasks.Dataflow;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");

//         Scripture sr = new Scripture( "John", 3, 17, "For God so loved the world that he gave his only begotten son." );    
        
//         Console.WriteLine("\n");
//         sr.ShowScripture();

//         string refferal = sr.GetScriptureReference();
//         Console.WriteLine(refferal);

//         Console.WriteLine("\n");   
//     }       
// }
        
        
        
        
        
        
        
        
        
// //  // TESTING SECTION
        
//         // Word bork  = new Word();

//         // bork.SetWord();
//         // bork.DisplayWord();
//         // bork.Hide();
//         // bork.DisplayWord(); 
