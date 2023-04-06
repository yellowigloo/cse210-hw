using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.WriteLine("Please select one of the following choices(1-5):");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine($"{rnd}");
        string promptChoice = Console.ReadLine();
        Journal journal = new Journal();
        Entry entry = new Entry();
        while (promptChoice != "5"){
            if (promptChoice == "1"){
                entry.WriteLog();
            }
            else if (promptChoice == "2"){
                journal.DisplayLog();
            }
            else if (promptChoice == "3"){
                return;
            }
            else if (promptChoice == "4"){
                return;
            }
            else{
                Console.WriteLine("Please choose from 1-5");
            }
        }
    }
}