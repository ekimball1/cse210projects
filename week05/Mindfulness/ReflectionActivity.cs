using System;
using System.Collections.Generic;


public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for your belief's.",
        "Think of a time you received an unexpected and kind gesture.",
        "Think of a time someone genuinely thanked you.",
        "Think of a time you selflessly served."
    };

    private List<string> _questions = new List<string>()
    {
        "How did this make you feel, and why?",
        "How did this experience change you?",
        "If you could relive the moment, would you?",
        "What did you enjoy most about the experience?"
    };

    public ReflectionActivity()
        : base( 
              "Reflection",
              "This activity will help you reflect on times in your life when you have demonstrated strength and resilience. This will help you recognize the power you have and you can use it daily.")
    {
    }   

    public void Run()
    {
        DisplayBeginningMessage();

        Random random = new Random();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"---{_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue");
        Console.WriteLine();

        Console.WriteLine("\nNow think about each of the following questions:");
        ShowSpinner(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.Write($"\n> {question} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
