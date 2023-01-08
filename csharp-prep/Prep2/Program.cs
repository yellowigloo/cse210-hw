using System;
class Program
{
    static void Main(string[] args)
    {
        string letterGrade="";
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string sign = "";
        if (grade <93 && grade >=60){
            if (grade % 10 <3){
                sign = "-";
            }
            else if (grade % 10 >=7){
                sign = "+";
            }
        }
        if (grade >= 90){
            letterGrade = "A";
        }
        else if (grade >= 80){
            letterGrade = "B";
        }
        else if (grade >= 70){
            letterGrade = "C";
        }
        else if (grade >= 60){
            letterGrade = "D";
        }
        else if (grade < 60){
            letterGrade = "F";
        }
        else {
            Console.WriteLine("Error");
        }
        Console.WriteLine($"You got a {sign}{letterGrade}");
    }
}