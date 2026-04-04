using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Begin breathing activity");
            Console.WriteLine(" 2. Begin reflection activity");
            Console.WriteLine(" 3. Begin listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice =="2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice =="3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice =="4")
            {
                Console.WriteLine("Goodbye!");
            }
            
            else
            {
                Console.WriteLine("Invalid choice.");
                
            }

            if (choice !="4")
            {
                Console.WriteLine("\nPress Enter to return to the main menu.");
                Console.ReadLine();
            }
        } 
    }             
}        
 