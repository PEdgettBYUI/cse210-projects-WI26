class Journal
{
    // copy of filename used for journal
    public string _journalName;

    // List of all Journal Entries (from .txt file)
    private List<Entry> Entries = new List<Entry>();

    // Add a given Entry to the current Journal
    public void AddEntry(Entry _entry)
    {
        Entries.Add(_entry);
    }

    // Retrieve list for use from the menu
    public List<Entry> EntriesList
    {
        get {return Entries;}
    }

    // Initialize Journal

    // Create a new Entry & append to list<>Entries

    // Save entries in Entries<> to a given filename.txt

    // Load Journal from a .txt file

    // Display all entires in the current Journal

    


}