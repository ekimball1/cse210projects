using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
{
    return _name;
}

public void DisplayBeginningMessage()
    {
        
        Console.Clear();
        Console.WriteLine($"Welcome to your {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like your session?");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nNicely done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>(){"|", "/","-", "\\"};

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if(i>=spinner.Count)
            {
                i=0;

            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i=seconds;i>0;i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}