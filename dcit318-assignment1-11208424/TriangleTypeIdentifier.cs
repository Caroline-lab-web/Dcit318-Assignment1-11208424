using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides:");

        Console.Write("Side A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Side B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Side C: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Triangle is Equilateral.");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("Triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("Triangle is Scalene.");
        }
    }
}