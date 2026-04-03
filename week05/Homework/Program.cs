using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment(
            "Liana Lopez",
            "Division",
            "2.1",
            "1-10"
        );

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment(
            "Aldo Walten",
            "History 101",
            "The Effects of the Cold War"
        );

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}