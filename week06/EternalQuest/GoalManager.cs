
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int choice = 0;

        while (choice !=6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select an option from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice ==1)
            {
                CreateGoal();
            }
            else if (choice ==2)
            {
                ListGoalDetails();
            }
            else if (choice ==3)
            {
                SaveGoals();
            }
            else if (choice==4)
            {
                LoadGoals();
            }
            else if (choice==5)
            {
                RecordEvent();
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have earned {_score} points!");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goal options are: ");
        for (int i = 0; i< _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour goals are:");
        for (int i =0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe type of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("Which type of goal will you create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What would you like to name your goal? ");
        string name = Console.ReadLine();

        Console.Write("Provide a short description for it. ");
        string description = Console.ReadLine();

        Console.Write("How many points are associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == 2)
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == 3)
        {
            Console.Write("How many times will this goal need to be accomplished to earn a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.WriteLine("Which goal did you complete today?");
        int goalNumber = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[goalNumber - 1];
        int pointsEarned = selectedGoal.RecordEvent();

        _score += pointsEarned;

        Console.WriteLine($"\nCongrats! You earned {pointsEarned} points today!");
        Console.WriteLine($"You now have {_score} points, way to go!");

        ShowEncouragingMessage();
    }

    public void SaveGoals()
    {
        Console.Write("What would you like to name this goal file? ");
        string fileName = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i<lines.Length; i++)
        {
            string[]parts = lines[i].Split('|');

            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (goalType =="EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points,target,bonus, amountCompleted);
                _goals.Add(goal);
            }
        }
    }

    public void ShowEncouragingMessage()
    {
        List<string> scriptures = new List<string>()
        {
            "Philippians 4:13 - I can do all things through Christ which strengthened me.",
            "Doctrine and Covenants 64:33 - Be not weary in well-doing.",
            "2 Nephi 31:20 - Press forward with Steadfastness in Christ.",
            "Mosiah 2:41 - Consider the blessed and happy state of those that keep the commandments of God."
        };

        Random random = new Random();
        int index = random.Next(scriptures.Count);

        Console.WriteLine($"\nEncouragement: {scriptures[index]}");
    }
 }