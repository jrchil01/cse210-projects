using System;

class Program
{
    //displays the menu and returns user's choice
    static string Menu()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("Enter one of the above numbers to continue: ");
        string choice = Console.ReadLine();
        return choice;
    }

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal App!");
        string choice = Menu();

        while (choice != "5"){
            
            if (choice == "1"){
                //Writes a new Entry and adds it to the Journal
                Console.WriteLine();
                Entry newEntry = new Entry();
                newEntry.Write();
                journal._entries.Add(newEntry);
                Console.WriteLine();
            }else if (choice == "2"){
                //Displays all Entries in the Journal
                Console.WriteLine();
                journal.Display();
            }else if(choice == "3"){
                //Loads a journal from a text file
                Console.WriteLine();
                journal.Load();
            }else if(choice == "4"){
                //Saves a Journal to a text file
                Console.WriteLine();
                journal.Save();
            }else{
                //Error message
                Console.WriteLine("Oops! Something went wrong. Please try again!");
            }
            choice = Menu();
        }
    }
}