using System;

using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "When did you experience a tender mercy?",
        "What is one thing you were proud you did today?",
        "What did you pray about today?",
        "Who were you glad you spoke to today?",
        "Who are people that have helped you this week without you needing to ask?",
    };

    public ListingActivity()
    :base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things you can in a certain area.")

    {
        
    }

    public void Run()
{
    DisplayBeginningMessage();

    Random random = new Random();

    Console.WriteLine("\nList as many responses as you can to the following ptompt".);
    Console.WriteLine($"---{_prompts[random
    .Next(_prompts.Count)]}");

    Console.Write("/nYou may begin in:");
    ShowCountdown(5);
    Console.WriteLine();

    int count = 0;
    DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
        Console.Write(">");
        Console.ReadLine();
        count++;
    }

    Console.Write($"\nWOw, you listed {count} items!");

    DisplayEndingMessage();
}
}