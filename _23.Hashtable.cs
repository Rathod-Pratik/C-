using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1, "One");
        hashtable.Add(2, "Two");
        hashtable.Add(3, "Three");

        hashtable.Remove(2); // Remove by key

        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}