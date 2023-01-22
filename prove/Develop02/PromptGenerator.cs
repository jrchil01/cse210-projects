using System;

public class PromptGenerator
{
    public PromptGenerator()
    {
    }

    public string Generate()
    {   
        //creates a list of prompts
        List<string> prompts = new List<string>();
        prompts.Add("What was the best part of my day?");
        prompts.Add("How have I seen the Lord in my life today?");
        prompts.Add("If I could do one thing over today, what would it be?");
        prompts.Add("What was the most interesting part of my day?");
        prompts.Add("What was something random I noticed today?");
        prompts.Add("How do I want today to be remembered?");

        //randomizes which prompt is displayed
        Random rnd = new Random();
        int num = rnd.Next(0, 6);

        return prompts[num];
    }
}