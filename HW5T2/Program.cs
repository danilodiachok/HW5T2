using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Dictionary<uint, string> personDictionary = new Dictionary<uint, string>();

        
        for (int i = 0; i < 7; i++)
        {
            Console.Write("Enter ID: ");
            if (uint.TryParse(Console.ReadLine(), out uint id))
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                personDictionary[id] = name;
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid positive number.");
                i--; 
            }
        }

        Console.Write("Enter ID to find Name: ");
        if (uint.TryParse(Console.ReadLine(), out uint searchID))
        {
            if (personDictionary.ContainsKey(searchID))
            {
                string foundName = personDictionary[searchID];
                Console.WriteLine($"Name for ID {searchID}: {foundName}");
            }
            else
            {
                Console.WriteLine($"ID {searchID} not found in the Dictionary.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID. Please enter a valid positive number.");
        }
    }
}