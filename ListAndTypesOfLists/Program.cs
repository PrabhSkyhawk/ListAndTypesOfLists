using System;
using System.Collections.Generic;
class Program
{
    public Program()
    {
        ListCountElements();
        CreateListAddElementToList();
        AccessElementByList();
        RemoveElementFromList();
        ListInsertElements();
        ListForEach();
        ListToArray();
    }
    public static void Main(string[] args)
    {
        new Program();
    }
    static void ListCountElements()
    {
        List<int> vars = [0, 1, 2, 3, 4, 5];
        Console.WriteLine($"there are {vars.Count} elements in the list");
        Console.WriteLine("................................");
    }
    void CreateListAddElementToList()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

        Console.WriteLine("List elements:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
            Console.WriteLine("................................");
        }
    }
    void AccessElementByList()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("First element: " + numbers[0] + ", Second element: " + numbers[1] + ", Third element: " + numbers[2]);
        Console.WriteLine("................................");
    }
    static void RemoveElementFromList()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("The original list: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num + " ");
        }

        int indexToRemove = 2;
        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
        {
            numbers.RemoveAt(indexToRemove);

            Console.WriteLine($"\nAfter removing element at index {indexToRemove}: ");
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
        }
        else
        {
            Console.WriteLine($"\nIndex {indexToRemove} is out of range.");
        }
    }
    void ListInsertElements()
    {
        List<string> words = new List<string> { "man", "is", "the", "beautiful", "masterpiece", "of", "the", "god" };
        words.Insert(0, "The");
        words.Insert(words.Count, "Almighty");
        Console.WriteLine(string.Join(" ", words));
        Console.WriteLine("................................");
    }
    void ListForEach()
    {
        List<string> words = ["forest", "oak", "river", "falcon"];

        words.ForEach(Console.WriteLine);
        words.ForEach(word => Console.WriteLine(word.ToUpper()));
        Console.WriteLine("................................");
    }
    void ListToArray()
    {
       List<int> numbers = new List<int> { 1, 2, 3, 4, 5,6,7,8,9 };
       int[] numbersArray = numbers.ToArray();
        Console.WriteLine("Array elements:");
        foreach (int num in numbersArray)
        {
            Console.Write(num + " ");
        }
    }
}
