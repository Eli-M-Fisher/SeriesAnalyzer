

using System;
using System.Collections.Generic;
using System.Linq;

public static class SeriesFunctions
{
    public static void PrintSeries(List<double> series)
    {
        Console.WriteLine("Series (original order):");
        Console.WriteLine(string.Join(", ", series));
    }

    public static void PrintReversed(List<double> series)
    {
        Console.WriteLine("Series (reversed):");
        Console.WriteLine(string.Join(", ", series.AsEnumerable().Reverse()));
    }

    public static void PrintSorted(List<double> series)
    {
        Console.WriteLine("Series (sorted ascending):");
        Console.WriteLine(string.Join(", ", series.OrderBy(x => x)));
    }

    public static void PrintMax(List<double> series)
    {
        Console.WriteLine($"Max value: {series.Max()}");
    }

    public static void PrintMin(List<double> series)
    {
        Console.WriteLine($"Min value: {series.Min()}");
    }

    public static void PrintAverage(List<double> series)
    {
        Console.WriteLine($"Average: {series.Average():F2}");
    }

    public static void PrintCount(List<double> series)
    {
        Console.WriteLine($"Number of elements: {series.Count}");
    }

    public static void PrintSum(List<double> series)
    {
        Console.WriteLine($"Sum: {series.Sum()}");
    }
}