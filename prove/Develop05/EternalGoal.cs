class EternalGoal : Goal{
    int a;
    public EternalGoal(){
        return;
    }
    public EternalGoal(string name, string description, int points) : base(name, description, points){
        return;
    }
    public override void GetGoalDescription(){
        Console.Write("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.Write("Give a description of it");
        string description = Console.ReadLine();
        Console.Write("How many points for doing it?");
        int points = int.Parse(Console.ReadLine());
        EternalGoal goal = new EternalGoal(name, description, points);
    }
}