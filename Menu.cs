

using System;
using System.Collections.Generic;

public static class Menu
{
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

    public static bool HandleMenuChoice(int choice, ref List<double> series)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter a new series (at least 3 positive numbers):");
                series = InputHelper.GetInitialSeries(Array.Empty<string>());
                break;
            case 2:
                SeriesFunctions.PrintSeries(series);
                break;
            case 3:
                SeriesFunctions.PrintReversed(series);
                break;
            case 4:
                SeriesFunctions.PrintSorted(series);
                break;
            case 5:
                SeriesFunctions.PrintMax(series);
                break;
            case 6:
                SeriesFunctions.PrintMin(series);
                break;
            case 7:
                SeriesFunctions.PrintAverage(series);
                break;
            case 8:
                SeriesFunctions.PrintCount(series);
                break;
            case 9:
                SeriesFunctions.PrintSum(series);
                break;
            case 10:
                return true;
            default:
                Console.WriteLine("Unknown option.");
                break;
        }

        return false;
    }
}