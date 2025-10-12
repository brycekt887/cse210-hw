using System;


public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

 
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine(); 
    }

    
    public string ToFileFormat()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

   
    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        Entry newEntry = new Entry();

        if (parts.Length >= 3)
        {
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
        }

        return newEntry;
    }
}
