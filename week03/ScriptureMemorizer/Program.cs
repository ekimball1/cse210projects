// This week I added the option for the user to enter a memory hint or analogy to help them memorize
//their scripture. The hint is stored in the Scripture class and is displayed when the program is running
//to reinforce learning and personalize the user's experience.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 7, 15);

        Scripture scripture = new Scripture(
            reference,
            @"Yea, I say unto you come and fear not, and lay aside every sin, which easily doth beset you, which
            doth bind you down to destruction, yea, come and go forth, and show unto your God that ye are
            willing to repent of your sins and enter into a covenant with him to keep his commandments,
            and witness it unto him this day by going into the waters of baptism."
            );

            Console.WriteLine("Would you like to enter a memory hint to help memorize your scripture? (y/n):");
            string choice = Console.ReadLine();
            
            if (choice.ToLower() =="y")
        {
            Console.Write("Please enter your memory hint: ");
            string hint = Console.ReadLine();
            scripture.SetMemoryHint(hint);
        }
            string input = "";
        
            while (input != "quit" && !scripture.AllWordsHidden())
            {
                Console.Clear();

                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.GetMemoryHint() != "")
                {
                    Console.WriteLine($"Hint: {scripture.GetMemoryHint()}");
                    Console.WriteLine();
                }

                Console.Write("Please press Enter to continue or type 'quit': ");
                input = Console.ReadLine();

                if(input != "quit")
                {
                    scripture.HideRandomWords();
                }   
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.GetMemoryHint() != "")
            {
                Console.WriteLine($"Hint: {scripture.GetMemoryHint()}");
                Console.WriteLine();
            
            }
            Console.WriteLine("Well done!");
    }
}