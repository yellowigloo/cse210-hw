using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName(){
            Console.WriteLine("What is your name? ");
            return Console.ReadLine();
        }
        static int PromptUserNumber(){
            Console.WriteLine("What is your favorite number? ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number){
            return number*number;
        }
        static void DisplayResults(string name, int squared){
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }
        DisplayResults(PromptUserName(),SquareNumber(PromptUserNumber()));
    }
}