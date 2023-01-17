using System;
class Program
{
    static void Main(string[] args)
    {
        int guess;
        //had to look at the random one
        Random randomGenerator = new Random();
        int mgNumber = randomGenerator.Next(1, 10);
        do{
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > mgNumber){
                Console.WriteLine("Lower");
            }
            else if (guess < mgNumber){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }while (guess != mgNumber);


    }
}