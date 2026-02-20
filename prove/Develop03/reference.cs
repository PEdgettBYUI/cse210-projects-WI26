class Reference
{
    private string _book;
    private int _chapter;
    private int? _verse;         // Nullable; for single verse
    private int? _startVerse;    // Nullable; for range start
    private int? _endVerse;      // Nullable; for range end

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _startVerse = null; // Nullified for single verse
        _endVerse = null;   // Nullified for single verse
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = null;     // Nullified for range of verses
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void ShowScriptureReference()
    {
        Console.Write($"{_book} {_chapter}:");

        if (_verse != null)
        {
            Console.Write($"{_verse}");
        }
        else
        {
            Console.Write($"{_startVerse} - {_endVerse}");
        }
    }

    public string GetScriptureReference()
    {
        string UH = $"{_book} {_chapter} {_verse}";
        return UH;
    }
}