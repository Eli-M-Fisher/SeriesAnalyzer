/*
 * Menu.cs
 *
 * This file is responsible for displaying the menu to the user and handling their choices.
 * It connects the user’s selection with the appropriate function to run from the SeriesFunctions.
 *
 * Think of this like the central control panel — it doesn’t do the work,
 * but it tells the right parts of the app what to do based on user input.
 *
 * Author: Eli Fisher
 * Part of the Series Analyzer project – C# programming course
 */

using System;
using System.Collections.Generic;

public static class Menu
{
    // Displays the main menu with all user options
    public static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Input a new series");
        Console.WriteLine("2. Display series (original order)");
        Console.WriteLine("3. Display series (reversed)");
        Console.WriteLine("4. Display series (sorted ascending)");
        Console.WriteLine("5. Display max value");
        Console.WriteLine("6. Display min value");
        Console.WriteLine("7. Display average");
        Console.WriteLine("8. Display number of elements");
        Console.WriteLine("9. Display sum");
        Console.WriteLine("10. Exit");
    }

    // Handles the action chosen by the user based on the menu option selected
    // Returns true if the user wants to exit, false otherwise
    public static bool HandleMenuChoice(int choice, ref List<double> series)
    {
        switch (choice)
        {
            case 1:
                // Replace the current series with new input from user
                Console.WriteLine("Enter a new series (at least 3 positive numbers):");
                series = InputHelper.GetInitialSeries(Array.Empty<string>());
                break;
            case 2:
                // Display the series as entered
                SeriesFunctions.PrintSeries(series);
                break;
            case 3:
                // Display the series in reverse order
                SeriesFunctions.PrintReversed(series);
                break;
            case 4:
                // Display the series sorted in ascending order
                SeriesFunctions.PrintSorted(series);
                break;
            case 5:
                // Show the maximum value in the series
                SeriesFunctions.PrintMax(series);
                break;
            case 6:
                // Show the minimum value in the series
                SeriesFunctions.PrintMin(series);
                break;
            case 7:
                // Show the average of the series
                SeriesFunctions.PrintAverage(series);
                break;
            case 8:
                // Show how many elements are in the series
                SeriesFunctions.PrintCount(series);
                break;
            case 9:
                // Show the sum of all elements in the series
                SeriesFunctions.PrintSum(series);
                break;
            case 10:
                // Exit the program loop
                return true;
            default:
                Console.WriteLine("Unknown option.");
                break;
        }

        return false;
    }
}