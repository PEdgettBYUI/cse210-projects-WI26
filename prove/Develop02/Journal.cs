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

            Console.WriteLine($"[JournalCreated: {_journalName}]\n\n");

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
    public void LoadJournal(string filename)
    {
        // IF filename.txt doesnot exist, program will crash without the following handler
        if (System.IO.File.Exists(filename))
        {
            // Takes a given {name}.txt file and breaks it down line by line into multiple entries in a list
        string[] lines = System.IO.File.ReadAllLines(filename);     //REMINDER: The extension(.txt) is applied automatically

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            
            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();
            entry.EntryFromFile(date, question, entryText);
            this.AddEntry(entry);   //NOTE: 'this' is a keyword used to refer to the class the word is in
        }
        _journalName = filename;
        Console.WriteLine("[LOAD complete!]\n");
        }
        else
        {
            Console.WriteLine($"ERROR!\nThe File: \"{filename}\" Does Not Exist within the save directory.\nPlease provide an existing filename.\n\n");
        }
        
    }

    // Display all entires in the current Journal
    public void DisplayJournal()
    {
        // Display filename, as reminder to the user
        if (string.IsNullOrEmpty(_journalName))
        {
            Console.WriteLine("[NO NAME] Journal");
        }
        else
        {
            Console.WriteLine($"Journal: {_journalName}\n\n");
        }

        // Display every entry in the journal
        // NOTE: Make Pretty
        foreach (Entry item in Entries)
        {
            string EntryString = item.convertEntryString();
            Console.WriteLine(EntryString.Replace('#', '\n'));
            Console.WriteLine();
            /* Displays all entries in the Entries List when left blank
            OR shows the contents of a specific journal entry*/
        }
        Console.WriteLine($"--Total Entries: {Entries.Count}--\n");
        
        // Wait for User INput before continuing
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();  //NOTE: Waits for input before coninuing if BLANK
    }



}