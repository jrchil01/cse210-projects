using System;
class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Reference ref1 = new Reference("John", "3", "16");
        Scripture scripture1 = new Scripture(ref1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him shall not perish, but have everlasting life.");

        Reference ref2 = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture2 = new Scripture(ref2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while(input != "quit"){
            Console.Clear();
            scripture1.Display();
            if(scripture1.IsCompleteHidden())
            {
                input = "quit";
                break;
            }
            Console.WriteLine("\n\nPress the enter key to continue or type 'quit' to quit.");
            input = Console.ReadLine();
            scripture1.HideWords();
        }

        Console.WriteLine("\n\nPress enter to continue to the next scripture");
        input = Console.ReadLine();

        while(input != "quit")
        {
            Console.Clear();
            scripture2.Display();
            if(scripture2.IsCompleteHidden())
            {
                input = "quit";
                break;
            }
            Console.WriteLine("\n\nPress the enter key to continue or type 'quit' to quit.");
            input = Console.ReadLine();
            scripture2.HideWords();
            
        }
    }
}