

using System;
using System.Collections.Generic;
using System.Linq;

public static class SeriesFunctions
{
    public static void PrintSeries(List<double> series)
    {
        Console.WriteLine("Series (original order):");
        for (int i = 0; i < series.Count; i++)
        {
            Console.Write(series[i]);
            if (i < series.Count - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }

    public static void PrintReversed(List<double> series)
    {
        Console.WriteLine("Series (reversed):");
        for (int i = series.Count - 1; i >= 0; i--)
        {
            Console.Write(series[i]);
            if (i > 0)
                Console.Write(", ");
        }
        Console.WriteLine();
    }

    public static void PrintSorted(List<double> series)
    {
        List<double> sortedSeries = new List<double>(series); // נעתיק כדי לא לשנות את המקור

        for (int i = 0; i < sortedSeries.Count - 1; i++)
        {
            for (int j = 0; j < sortedSeries.Count - i - 1; j++)
            {
                if (sortedSeries[j] > sortedSeries[j + 1])
                {
                    double temp = sortedSeries[j];
                    sortedSeries[j] = sortedSeries[j + 1];
                    sortedSeries[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Series (sorted ascending):");
        Console.WriteLine(string.Join(", ", sortedSeries));
    }

    public static void PrintMax(List<double> series)
    {
        double max = series[0];
        foreach (double num in series)
        {
            if (num > max)
                max = num;
        }
        Console.WriteLine($"Max value: {max}");
    }

    public static void PrintMin(List<double> series)
    {
        double min = series[0];
        foreach (double num in series)
        {
            if (num < min)
                min = num;
        }
        Console.WriteLine($"Min value: {min}");
    }

    public static void PrintAverage(List<double> series)
    {
        double sum = 0;
        foreach (double num in series)
        {
            sum += num;
        }
        double average = sum / series.Count;
        Console.WriteLine($"Average: {average:F2}");
    }

    public static void PrintCount(List<double> series)
    {
        int count = 0;
        foreach (double _ in series)
        {
            count++;
        }
        Console.WriteLine($"Number of elements: {count}");
    }

    public static void PrintSum(List<double> series)
    {
        double sum = 0;
        foreach (double num in series)
        {
            sum += num;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}