using System;
using System.Collections.Generic;

class App
{
    static void Main()
    {
        // Input list of integers
        List<int> L = new List<int> { 18, 5, 47, 56, 15, 78, 19, 49, 91, 60, 59, 17 };

        // Call the function and get the result
        List<List<int>> result = GroupNumbers(L);

        // Display the result
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"Range {i * 10}-{i * 10 + 9}: {string.Join(", ", result[i])}");
        }
    }

    static List<List<int>> GroupNumbers(List<int> L)
    {
        // Initialize the 10 lists
        List<List<int>> groupedLists = new List<List<int>>();
        for (int i = 0; i < 10; i++)
        {
            groupedLists.Add(new List<int>());
        }

        // Add numbers to their corresponding lists
        foreach (int num in L)
        {
            int rangeIndex = num / 10;
            groupedLists[rangeIndex].Add(num);
        }

        // Ensure each sublist starts with the largest value
        for (int i = 0; i < groupedLists.Count; i++)
        {
            if (groupedLists[i].Count > 0)
            {
                int maxValue = MaxValue(groupedLists[i]);
                groupedLists[i].Remove(maxValue);
                groupedLists[i].Insert(0, maxValue);
            }
        }

        return groupedLists;
    }

    static int MaxValue(List<int> list)
    {
        int max = int.MinValue;
        foreach (int num in list)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}
