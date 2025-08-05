using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter numerical grade (0-100): ");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        Console.WriteLine($"Your grade is: {letter}");
    }
}