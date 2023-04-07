class ChecklistGoal : Goal{
    string _parameters;
    int _bonus;
    int _bonusTimes;
    public ChecklistGoal(){
        _bonus = 0;
        _bonusTimes = 0;
    }
    public ChecklistGoal(string name, string description, int points, int bonusTimes, int bonus) : base(name, description, points){
        _bonus = bonus;
        _bonusTimes = bonusTimes;
    }
    public override void GetGoalDescription(){
        Console.Write("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.Write("Give a description of it");
        string description = Console.ReadLine();
        Console.Write("How many points for doing it?");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times does it need to be done for a bonus?");
        int bonusTimes = int.Parse(Console.ReadLine());
        Console.Write("How many many points is the bonus?");
        int bonus = int.Parse(Console.ReadLine());
        ChecklistGoal goal = new ChecklistGoal(name, description, points, bonusTimes, bonus);
    }
}