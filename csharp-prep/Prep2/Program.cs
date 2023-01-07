using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        string sign = "";
        
        //determines the letter grade
        if(grade >= 90){
            letter = "A";
        }else if(grade >= 80){
            letter = "B";
        }else if(grade >= 70){
            letter = "C";
        }else if(grade > 60){
            letter = "D";
        }else{
            letter = "F";
        }

        //determines grade sign
        if(grade % 10 >= 7){
            if(letter != "A" && letter != "F"){
                sign = "+";
            }
        }else if(grade % 10 <= 3){
            if(letter != "F"){
               sign = "-";
            }
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        //gives a message based on if you pass or fail
        if(grade >= 70){
            Console.WriteLine("Congratulations for passing the class!");
        }else{
            Console.WriteLine("Better luck next time!");
        }
    }
}