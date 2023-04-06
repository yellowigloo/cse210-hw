using System;
class Program
{
    static void Main(string[] args)
    {   
        int number = 1;
        int counter = -1;
        int sum = 0;
        int largestNum = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0){
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            sum+=number;
            counter++;
            if (largestNum < number){
                largestNum = number;
            }
        }
        int average = sum/counter;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}