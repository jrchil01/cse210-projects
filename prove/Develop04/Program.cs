using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        
        while(input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if(input == "1")
            {
                BreathingActivity Breathe = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Breathe.DisplayStartMessage();
                Breathe.Breath();
                Breathe.DisplayEndMessage();
            }
            else if(input == "2")
            {
                ReflectionActivity Reflection = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Reflection.DisplayStartMessage();
                Reflection.Reflect();
                Reflection.DisplayEndMessage();
            }
            else if(input == "3")
            {
                ListActivity List = new ListActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                List.DisplayStartMessage();
                List.Listing();
                List.DisplayEndMessage();
    
            }
        }
    }
}