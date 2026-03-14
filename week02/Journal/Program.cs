// For creativity, I added an positive emotion field to the journal entry to encourage users to
//focus on the positive daily moments they experience. If every journal entry leaves the user with a positive outlook 
//perhaps the positivty will reshape the user's perspective on life.

using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator  = new PromptGenerator();

        int option = 0;

        while (option !=5)
        {
            Console.WriteLine("Welcome to iJournal!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Freewrite");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            option = int.Parse(input);

            if (option ==1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.WriteLine("What positive emotion best describes your day?");
                Console.Write("> ");
                string emotion = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._emotion = emotion;

                journal.AddEntry(newEntry);
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (option == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (option == 5)
            {
                Console.WriteLine("Thank you, goodbye!");
            }
            else
            {
                Console.WriteLine("Please choose one of the available options.");
            }
            
            Console.WriteLine();
        }
    }
}