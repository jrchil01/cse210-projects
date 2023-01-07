using System;

class Program
{
    static void Main(string[] args)
    {
        //inputs first and last names
        Console.WriteLine("What's your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What's your last name? ");
        string lastName = Console.ReadLine();

        //outputs modified James Bond quote.
        Console.WriteLine($"The name's {lastName}, {firstName} {lastName}.");
    }
}