using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");

        sortedList.Remove(1); // Remove by key

        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}