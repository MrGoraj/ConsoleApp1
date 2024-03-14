﻿class ConsoleApp1
{
    static void Main(string[] args)
    {
        // Example array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Calling the CalculateAverage method and displaying the result
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Average: {average}");
    }

    // Static method to calculate the average
    public static double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        double sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }

        return sum / array.Length;
    }
}