class ConsoleApp1
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Average: {average}");
        
        int max = FindMaximum(numbers);
        Console.WriteLine($"Maximum value: {max}");
    }

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
    
    public static int FindMaximum(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        int max = array[0];
        foreach (int number in array)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }
}