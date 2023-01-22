using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Journal()
    {
    }

    //Displays all Entries in a Journal
    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    //Saves all entries in a journal to a text file
    public void Save()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }


    //Reads a text file and creates a new journal from it
    public void Load()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        //reads each line and breaks it up into pieces to make a new Entry
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._entry = parts[2];
            _entries.Add(newEntry);
        }
    }
}