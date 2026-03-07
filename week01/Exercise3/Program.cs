using System;

class Program
{
    static void Main(string[] args)
    {

        string playAgain = "yes";
        while(playAgain =="yes")
        {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.Write("Guess the magic number.");
            int guess = int.Parse(Console.ReadLine());
       

            while (guess != magicNumber)
            {

                if (guess < magicNumber)
                {
                    Console.WriteLine("Not quite. Guess higher.");
                }
                    else if (guess > magicNumber)
                {
                    Console.WriteLine("Not quite. Guess lower.");
                }

                Console.Write("Try again: ");
                guess = int.Parse(Console.ReadLine());
            }    
      
       
                Console.WriteLine("That's correct! You guessed it!");

                    
                Console.Write("Would you like to play again? (yes/no): ");
                playAgain= Console.ReadLine();
    
        }
    }
}        