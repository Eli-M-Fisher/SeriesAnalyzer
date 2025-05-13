/*
 * Program.cs
 * 
 * This is the main entry point for the Series Analyzer app.
 * It kicks off the whole program, starting from greeting the user,
 * handling input (from args or manual entry), and showing the menu.
 * 
 * Basically, this file manages the main program loop
 * and delegates the actual work to other helper modules.
 * 
 * Author: Eli Fisher
 * Created for: C# programming course – group project
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // Clears the console for a clean start
        Console.WriteLine("Welcome to the Series Analyzer!\n"); // Friendly greeting to the user

        // Try to load the series from command line arguments; fallback to manual input if invalid
        List<double> series = InputHelper.GetInitialSeries(args);

        // Main program loop: keep showing menu until user decides to exit
        while (true)
        {
            Menu.DisplayMenu(); // Show the list of options
            int choice = InputHelper.GetMenuChoice(); // Get user's menu choice

            bool shouldExit = Menu.HandleMenuChoice(choice, ref series); // Handle the chosen action
            if (shouldExit)
                break; // Exit the loop if user selected 'Exit'
        }

        Console.WriteLine("\nThank you for using Series Analyzer!"); // Goodbye message
    }
}
