using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    //  new entry 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays 
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found. Try writing something first!\n");
            return;
        }

        Console.WriteLine("----- Journal Entries -----\n");

        foreach (Entry e in _entries)
        {
            e.Display();
        }

        Console.WriteLine("----- End of Journal -----\n");
    }

    // Saves 
    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                sw.WriteLine(e.ToFileFormat());
            }
        }

        Console.WriteLine($"Journal saved to {filename}\n");
    }

    // Loads 
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Try again.\n");
            return;
        }

        _entries.Clear(); //CLEAR

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                Entry e = Entry.FromFileFormat(line);
                _entries.Add(e);
            }
        }

        Console.WriteLine($"Loaded {_entries.Count} entries from {filename}\n");
    }
}
