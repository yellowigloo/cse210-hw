using System;
public class Entry
{
    public string _name ="Anonymous";
    public string _response ="";
    string[] prompts = File.ReadAllLines("prompts.txt");
    int lineCount = File.ReadAllLines("prompts.txt").Length;
    // Random rnd = new Random();
    // int randomLine;
    // int randomLine = rnd.Next(lineCount-1);
    //string prompt = File.ReadLines("prompts.txt").Skip(randomLine).Take(1).First();
    // public List<Journal> _journals = new List<Journal>();
    // public void LogEntry()
    // {
    //     Console.WriteLine($"Name: {_name}\nJournals: ");
    //     foreach (Journal journal in _journals)
    //     {
    //         Console.WriteLine($"{journal}");
    //     }
    // }
    public void WriteLog()
    {
        // public int random => lineCount.Next();
        Random rnd = new Random();
        int randomLine = rnd.Next(lineCount-1);
        // string prompt = File.ReadLines("prompts.txt").Skip(randomLine)).Take(1).First();
        // Console.WriteLine($"{prompts[randomLine]}");
        Console.WriteLine($"{prompt}");
        string response = Console.ReadLine();
        // using (StreamWriter line = File.AppendText("TempJournal.txt"))
        // {
        //     line.WriteLine($"Date: {DateTime.Today} - Prompt: {randomLine}");
        //     line.WriteLine($"{response}");
        // }

        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        tempJournal.Append(response);
        tempJournal.Append(currentTime);
        tempJournal.Append(prompts[randomLine]);


        // string[] entry = {
        //     $"Date: {date} - Prompt: {randomLine}", $"{response}"
        // };
        //File.WriteAllLines("Journal.txt", entry);
        //write prompt, answer, and date as an entry

    }


}