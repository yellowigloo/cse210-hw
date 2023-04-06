using System;
public class Journal
{
    // make this a list of entries
    List<int> _oldJournal;
    List<Entry> tempJournal = new List<Entry>();
    
    
    public void DisplayLog()
    {
        Console.WriteLine($"{_oldJournal}");
        Console.WriteLine($"{tempJournal}");
    }
    public void SaveLog()
    {
        Console.WriteLine("What is the file name?");
        string file = Console.ReadLine();
        // make or add to file
        foreach (string line in tempJournal){
            File.WriteAllText(file, line);
        }
    }
    public void LoadLog()
    {
        Console.WriteLine("What is the file name?");
        string file = Console.ReadLine();
        // prepend()
        // add file to beginning of temp file
        lines = System.IO.File.ReadAllLines(file);
        //tempJournal.AddRange(lines); i decieded to do a loop to add to the beginning instead
        foreach (string line in lines)
        {
            tempJournal.Prepend(line);
        }
    }
    
    public void Quit()
    {
        return;
    }

}