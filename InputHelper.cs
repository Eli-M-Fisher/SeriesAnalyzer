/*
 * InputHelper.cs
 * 
 * This file handles user input and validation for the Series Analyzer.
 * It knows how to read a series of numbers from either the command line
 * or interactively from the console, and makes sure the input is valid.
 * 
 * It also helps with safely collecting a menu option from the user.
 * Basically, this file protects the program from bad input.
 * 
 * Author: Eli Fisher
 * Part of the Series Analyzer project – C# course
 */

using System;
using System.Collections.Generic;

public static class InputHelper
{
    // Tries to read a valid series from command-line args.
    // If args are invalid or not present, asks the user to input a valid series manually.
    public static List<double> GetInitialSeries(string[] args)
    {
        List<double> series = new List<double>();

        // Try reading from command-line arguments
        if (args.Length >= 3)
        {
            bool valid = true;
            foreach (var arg in args)
            {
                if (double.TryParse(arg, out double num) && num > 0)
                    series.Add(num);
                else
                    valid = false;
            }

            if (valid)
            {
                return series;
            }
        }

        // Fallback: ask user to enter a valid series
        Console.WriteLine("Please enter at least 3 positive numbers separated by spaces:");
        while (true)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<double> tempSeries = new List<double>();
            bool valid = true;

            // Validate each part
            foreach (var part in parts)
            {
                if (double.TryParse(part, out double num) && num > 0)
                    tempSeries.Add(num);
                else
                    valid = false;
            }

            // If valid and long enough, return it
            if (valid && tempSeries.Count >= 3)
                return tempSeries;
            else
                Console.WriteLine("Invalid input. Please enter at least 3 positive numbers:");
        }
    }

    // Prompts the user to choose a valid menu option (1-10) and validates the choice.
    public static int GetMenuChoice()
    {
        Console.Write("Choose an option (1-10): ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 10)
                return choice;
            Console.Write("Invalid choice. Please enter a number between 1 and 10: ");
        }
    }
}
