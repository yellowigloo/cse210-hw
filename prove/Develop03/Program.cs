using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", "3", "16");
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture script = new Scripture(ref1, text);
        Word wordsText = new Word(text);

        string choice = "";
        // int dif;
        script.DisplayScripture();
        Console.WriteLine($"\nWords will begin to disappear");
        Console.ReadLine();
        while (choice != "no"){
            // Console.WriteLine("What dificulty do you want the scripture to be?(0-10)");
            // dif = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            wordsText.DisplayHiddenText();
            Console.WriteLine();
            Console.WriteLine("Do you want to continue?('yes' or 'no')");
            choice = Console.ReadLine();
        }
    }
}