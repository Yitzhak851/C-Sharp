using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int>[] CategorizeNumbers(List<int> numbers)
    {
        List<int>[] categorized = new List<int>[10]; // Create an array of 10 lists
        for (int i = 0; i < 10; i++)
        {
            categorized[i] = new List<int>();
        }
        // Categorize numbers into their respective ranges
        foreach (int number in numbers)
        {
            int index = number / 10;
            categorized[index].Add(number);
        }
        // Ensure the first element in each list is the largest
        for (int i = 0; i < 10; i++)
        {
            if (categorized[i].Count > 0)
            {
                categorized[i] = categorized[i].OrderByDescending(x => x).ToList();
            }
        }
        return categorized;
    }

    static void PrintResult(List<int>[] result)
    {
        Console.WriteLine("Categorized Numbers:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(string.Format("Range {0}-{1}:", i * 10, i * 10 + 9));
            if (result[i].Count > 0)
            {
                Console.WriteLine(string.Format("  Largest: {0}", result[i][0]));
                Console.WriteLine("  All: " + string.Join(", ", result[i]));
            }
            else
            {
                Console.WriteLine("  No numbers in this range.");
            }
        }
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 18, 5, 47, 56, 15, 78, 19, 49, 91, 60, 59, 17 };
        List<int>[] result = CategorizeNumbers(numbers); // Get the categorized numbers
        PrintResult(result); // Print the results
    }
}
