using System;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice = "0";
        SimpleGoal goal = new SimpleGoal();
        while (menuChoice != "6"){
            goal.Menu();
            menuChoice = Console.ReadLine();
            if (menuChoice == "1"){
                goal.CreateGoal();
            }
            else if (menuChoice == "2"){
                goal.ListGoals();
            }
            else if (menuChoice == "3"){
                goal.SaveGoals();
            }
            else if (menuChoice == "4"){
                goal.LoadGoals();
            }
            else if (menuChoice == "5"){
                goal.RecordEvent();
            }
        }
    }
}