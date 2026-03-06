class Scripture
{
    private List<Word> _words;

    private Reference _reference;


public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new Reference(name, chapter, verse);
        _words = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(name, chapter, startVerse, endVerse);
        _words = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }


    public void ShowScripture()
    {
        _reference.ShowScriptureReference();

        Console.WriteLine();

        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }
    

    public string GetScriptureReference()
    {
        string refferal = _reference.GetScriptureReference();

        return refferal;

    }

    public int HowManyVisible()
    {
        int visible_count = 0;

        foreach (Word word in _words)
        {
            if (word.GetHidden() == false)
            {
                visible_count++;
            }
        }

        return visible_count;
    }

    public bool HideSomeWords()
    {
        int current_visible = HowManyVisible();

        if (current_visible >= 5)
        {
            List<Word> visible_only = new List<Word>();

            foreach (Word word in _words)
            {
                if (word.GetHidden() == false)
                {
                    visible_only.Add(word);
                }
            }

            Random random = new Random();   // RNG
            for (int i = 0; i < 5; i++)
            {
                // From 0 to length of visible_only
                int toHide = random.Next(0, visible_only.Count);
                visible_only[toHide].Hide();
            }

            return false;   // Keep program going
        }
        else if (current_visible > 0)
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
            return false;   // Keep program going
        }
        else
        {
            // End of Program Call here
            return true;
        }
    }
}