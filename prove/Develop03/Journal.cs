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
    public void nameJournal()
    {
        if(string.IsNullOrEmpty(_journalName))
        {
            Console.WriteLine("Please name your Journal: ");
            _journalName = Console.ReadLine() + ".txt";

            Console.WriteLine($"[JournalCreated: {_journalName}]");

            // If file doesn't exist, create file/overwrite pre-existing file
            using (FileStream fs = File.Create(_journalName)) {}
        }
    }

    // Create a new Entry & append to list<>Entries
    public void CreateAndAddEntry()
    {
        Entry newEntry = new Entry();   // Create a new Entry object
        newEntry.NewEntry();            // Fill in the entry using Entry.CS function
        AddEntry(newEntry);             // Add the new Entry Object to List<>Entries
    }

    // Save entries in Entries<> to a given filename.txt
    public void SaveEntry (string filename, List<Entry> entries)
    {
        // Save current entry to list<>Entires
        // Takes Entry Object and variables (_date, _prompt, _response) as a single string and adds it to Journal's .txt file
        if (Entries.Count !=0)
        {
            using (StreamWriter outputfile = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    outputfile.WriteLine(entry.convertEntryString());
                }
            }
        }
        else
        {
            Console.WriteLine("[NO Entries. SAVE Failed]");
        }
    }

    // Load Journal from a .txt file
    
    // Display all entires in the current Journal




}