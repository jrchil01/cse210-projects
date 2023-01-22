using System;

public class Entry
{
    public string _prompt;
    public string _entry;
    public string _date;
    public Entry()
    {
    }

    //Writes a new Entry.
    public void Write()
    {
        //displays prompt
        PromptGenerator prompts = new PromptGenerator();
        _prompt = prompts.Generate();
        Console.WriteLine(_prompt);

        //writes entry
        _entry = Console.ReadLine();

        //saves date
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();
    }

    //Displays all information in an entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_prompt}");
        Console.WriteLine(_entry);
    }
}