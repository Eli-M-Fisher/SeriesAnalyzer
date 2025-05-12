using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Series Analyzer!\n");

        // אם הוזנו ארגומנטים - ננסה להשתמש בהם, אחרת נבקש מהמשתמש
        List<double> series = InputHelper.GetInitialSeries(args);

        while (true)
        {
            Menu.DisplayMenu();
            int choice = InputHelper.GetMenuChoice();

            bool shouldExit = Menu.HandleMenuChoice(choice, ref series);
            if (shouldExit)
                break;
        }

        Console.WriteLine("\nThank you for using Series Analyzer!");
    }
}
