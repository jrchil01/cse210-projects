using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUsername();
        int favNum = PromptUserNumber();
        int squared = SquareNumber(favNum);
        string display = DisplayResult(username, squared);
        Console.WriteLine(display);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUsername(){
        Console.Write("What is your username?: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("What is your favorite number?: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int root){
        int square = root * root;
        return square;
    }

    static string DisplayResult(string name, int num){
        string result = ($"{name}, the square of your favorite number is {num}");
        return result;
    }
}