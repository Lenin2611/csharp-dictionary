using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        Console.WriteLine("Count: ");
        Console.WriteLine("the length of the dictionary is : {0}", dictionary.Count);

        Console.WriteLine("\nAdd: ");
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        dictionary.Add(4, "Four");
        foreach (Object number in dictionary)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nAdd Wrong: ");
        try
        {
            dictionary.Add(1, "One");
        }
        catch
        {
            Console.WriteLine("An element with key 1 already exists.");
        }
        
        Console.WriteLine("\nKeyCollection: ");
        Dictionary<int, string>.KeyCollection keyCollection = dictionary.Keys;
        foreach (int key in keyCollection)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nKeyValuePair: ");
        foreach(KeyValuePair<int, string> pair in dictionary)
        {
        Console.WriteLine("Key {0} - Value {1}", pair.Key, pair.Value);
        }

        Console.WriteLine("\nValueCollection: ");
        Dictionary<int, string>.ValueCollection valueCollection = dictionary.Values;
        foreach(string value in valueCollection)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("\n\nNew Dictionary: ");
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Lenin"] = 30;
        ages["Brayan"] = 25;
        ages["Iker"] = 40;
        foreach(Object a in ages)
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("\nContainsKey: ");
        string name = "Juan";
        bool containsKey = ages.ContainsKey(name);
        if (containsKey)
        {
            Console.WriteLine($"The dictionary contains the key '{name}' and its value is {ages[name]} years.");
        }
        else
        {
            Console.WriteLine($"The key '{name}' was not found in the dictionary.");
        }

        Console.WriteLine("\nContainsValue: ");
        int age = 25;
        bool containsValue = ages.ContainsValue(age);
        if (containsValue)
        {
            Console.WriteLine($"The dictionary contains the key '{age}' years.");
        }
        else
        {
            Console.WriteLine($"The value '{age}' was not found in the dictionary.");
        }

        Console.WriteLine("\nRemove: ");
        ages.Remove("Lenin");
        foreach(Object a in ages)
        {
            Console.WriteLine(a);
        }
    }
}