class Menu
{
    public void displayMenu()
    {
        Console.WriteLine ("      Menu\n1.Create New Entry\n2.Load Journal Entry\n3.Display Current Journal\n4.Save Current Journal\n5.Save Entry & Exit\n");
    }

    public void parseUserChoice(int choice, Entry anEntry, Journal aJournal)
    {
//Used for Saving Files
        string getJournalName = aJournal._journalName;
        List<Entry> getEntries = aJournal.EntriesList;

        switch (choice)
        {
            // Create new entry
            case 1:
                Console.WriteLine("[CREATING New Entry...]\n");
                // Create new Entry & add it to the Entries List
                aJournal.CreateAndAddEntry();
                // // Add entry to entries list
                // aJournal.AddEntry(anEntry);
                Console.WriteLine("   [ADDED entry to Journal]\n");
                // aJournal.DisplayJournal(); //TESTING
                break;

            //Load an existing journal
            case 2:
                Console.WriteLine("[LOADING Journal Entry...]\n");

                // Get filename of Journal.txt
                string filename;
                Console.Write("What is the filename? \n>");
                filename = Console.ReadLine() + ".txt";

                // Read from Journal.txt
                aJournal.LoadJournal(filename);
                break;

            // Display the entire contents of the Journal in an attractive manner
            case 3:
                // Display All Entries
                Console.WriteLine("[DISPLAYING Journal...]\n");
                Console.WriteLine("---------------------------------------------------");

                aJournal.DisplayJournal();

                Console.WriteLine("\n\n");
                break;

            // Saves the current entries in the journal to a file
            case 4:
                Console.WriteLine("[SAVING Current Journal to file...]\n");
                // Get filename of journal.txt
                aJournal.nameJournal();
                getJournalName = aJournal._journalName;

                // write journal with new entries to .txt file
                aJournal.SaveEntry(getJournalName, getEntries);
                break;

            // Triggers the EXIT command.
            // If there is any entries in the current journal, saves before quitting
            case 5:
                Console.WriteLine("[EXITING...]");
                // Checks if file has been saved, then does same as case 4 before quitting
                goto case 4;

            default:
                // Invalid Input Case 
                Console.WriteLine("[INVALID Input! Please put in a Valid Entry.]\n");
                break;
        }
    }

}