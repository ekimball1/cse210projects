using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        Console.WriteLine("Please enter a list of numbers, type 0 when finished.");

        int userNumber = -1;
        while (userNumber !=0)
    {
        Console.Write("Please enter number: ");
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);

        if (userNumber !=0)
        {
            numbers.Add(userNumber);
        }
    }

    int sum = 0;
    foreach (int number in numbers)
    {
            sum += number;
    }
    int max = numbers[0];
    foreach (int number in numbers)
    {
            if(number > max)
            {
                max = number;
            }
        }

        float average = (float)sum / numbers.Count;

        Console.WriteLine($"Your sum is: {sum}");
        Console.WriteLine($"Your average is: {average}");
        Console.WriteLine($"Your largest number is: {max}");
    }
}