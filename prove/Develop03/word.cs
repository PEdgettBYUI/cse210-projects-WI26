using System.Runtime.InteropServices;

class Word
{
    private string _word;
    bool _hidden = false;


    // Constructor
    public Word(string word)
    {
        _word = word;
    }

    // Test setter
    public void SetWord()
    {
        Console.Write("What is the word? ");
        _word = Console.ReadLine();
    }
    
    public void Hide()
    {
        if (_hidden == false) {
            _hidden = true;
        }
        else {
            _hidden = false;
        }
    }

    public void DisplayWord ()
    {
        if (_hidden == false)
        {
            Console.Write($"{_word} ");
        }
        else
        {
            for (int i = 0; i < _word.Length; i++)
            {
                Console.Write("_");
            }
            Console.Write(" "); // Space at the end of the word
        }
    }

}