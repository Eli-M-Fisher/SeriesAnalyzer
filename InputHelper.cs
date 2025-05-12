using System;
using System.Collections.Generic;

public static class InputHelper
{
    // קורא את הסדרה מה arguments או מהמשתמש
    public static List<double> GetInitialSeries(string[] args)
    {
        List<double> series = new List<double>();

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

        Console.WriteLine("Please enter at least 3 positive numbers separated by spaces:");
        while (true)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<double> tempSeries = new List<double>();
            bool valid = true;

            foreach (var part in parts)
            {
                if (double.TryParse(part, out double num) && num > 0)
                    tempSeries.Add(num);
                else
                    valid = false;
            }

            if (valid && tempSeries.Count >= 3)
                return tempSeries;
            else
                Console.WriteLine("Invalid input. Please enter at least 3 positive numbers:");
        }
    }

    // מקבל בחירה מהמשתמש עבור התפריט
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
