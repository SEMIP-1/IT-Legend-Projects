using System;

public class Read
{
    public int IntNumber()
    {
        int Number = 0;
        bool isConverted = int.TryParse(Console.ReadLine(), out Number);
        while (!isConverted)
        {
            Console.WriteLine("Enter a valid number");
            isConverted = int.TryParse(Console.ReadLine(), out Number);
        }
        return Number;
    }
    // Read double from user
    public double doubleNumber()
    {
        double Number = 0;
        bool isConverted = double.TryParse(Console.ReadLine(), out Number);
        while (!isConverted)
        {
            Console.WriteLine("Enter a valid number");
            isConverted = double.TryParse(Console.ReadLine(), out Number);
        }
        return Number;
    }
    // Read lines from user
    public string StringLines()
    {
        string? RL = Console.ReadLine();
        while (string.IsNullOrEmpty(RL))
        {
            Console.WriteLine("Enter a valid string");
            RL = Console.ReadLine();
        }
        return RL;
    }
    // Read Char from user
    public char CharLines()
    {
        char RL = ' ';
        bool isConverted = char.TryParse(Console.ReadLine(), out RL);
        while (!isConverted)
        {
            Console.WriteLine("Enter a valid Character");
            isConverted = char.TryParse(Console.ReadLine(), out RL);
        }
        return RL;
    }
    // Read DateTime from user
    public DateTime DateLines()
    {
        DateTime RL = new DateTime();
        bool isConverted = DateTime.TryParse(Console.ReadLine(), out RL);
        while (!isConverted)
        {
            Console.WriteLine("Enter a valid Date");
            isConverted = DateTime.TryParse(Console.ReadLine(), out RL);
        }
        return RL;
    }
}
