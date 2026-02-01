using System.Data;
using System.IO.Compression;

class Entry
{
    private string _date;

    private string _prompt;

    private string _response;

    // Read File
    public void EntryFromFile(string e_date, string e_prompt, string e_response)
    {
        _date = e_date;
        _prompt = e_prompt;
        _response = e_response;
    }

    // Set variables and Initialize Entry
    public void NewEntry()
    {
        setDate();
        setPrompt();

        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        recordResponse();
    }

    // List of Prompts
       private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today ?",
        "If I had one thing I could do over today, what would it be?",
        "What's one new thing you learned today?",
        "What's something productive you've done today?",
        "What's something you read/watched today?",
        "Did you see anyone interesting today?"
    };

    // Set Date for the current entry
    public void setDate()
    {
        DateTime currentDate = DateTime.Now;    // Retrieves in format (y/m/d)
        string dateAsString = currentDate.ToString("MMMM dd, yyyy");
        _date = dateAsString;
        // Console.WriteLine(dateAsString);
    }

    // Retrieve prompt from List
    public void setPrompt()
    {
        Random randomQuestion = new Random();
        string chosenPrompt = prompts[randomQuestion.Next(prompts.Count)];
        _prompt = chosenPrompt;
        // Console.WriteLIne(chosenPrompt);
    }

    // Record Entry Response to Prompt
    public void recordResponse()
    {
        Console.Write(">  ");
        _response = Console.ReadLine();
    }

    // Turn Class into a String for Storage in a .txt file
    public string convertEntryString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}"; 
        // Console.WriteLine(outputString);
        return outputString;
    }
 
}