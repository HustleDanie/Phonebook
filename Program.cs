using System;
using System.Collections.Generic;

class PhonebookEntry
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}

class Phonebook
{
    private List<PhonebookEntry> entries = new List<PhonebookEntry>();

    public void AddEntry(string name, string phoneNumber)
    {
        entries.Add(new PhonebookEntry { Name = name, PhoneNumber = phoneNumber });
    }

    public void PrintEntries()
    {
        Console.WriteLine("Phonebook entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry.Name}: {entry.PhoneNumber}");
        }
    }
}

class Program
{
    static void Main()
    {
        Phonebook phonebook = new Phonebook();

        // Add some entries to the phonebook
        phonebook.AddEntry("John Doe", "555-1234");
        phonebook.AddEntry("Jane Smith", "555-5678");
        phonebook.AddEntry("Bob Johnson", "555-9012");

        // Print the entries in the phonebook
        phonebook.PrintEntries();
    }
}
