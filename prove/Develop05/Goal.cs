abstract class Goal{
    string _name;
    string _description;
    int _points;
    public Goal(){
        _name = "";
        _description = "";
        _points = 0;
    }
    public Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetPoints(){
        return _points;
    }
    public int Menu(){
        Console.WriteLine($"You have {0} points");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        int menuChoice = int.Parse(Console.ReadLine());
        return menuChoice;
    }
    public void CreateGoal(){
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type would you like to make?");
        int goalChoice = int.Parse(Console.ReadLine());
        if (goalChoice == 1){
            SimpleGoal goal = new SimpleGoal();
            goal.GetGoalDescription();

        }
        else if (goalChoice == 2){
            EternalGoal goal = new EternalGoal();
            goal.GetGoalDescription();
        }
        else if (goalChoice == 3){
            ChecklistGoal goal = new ChecklistGoal();
            goal.GetGoalDescription();
        }
    }
    public void ListGoals(){
        Console.WriteLine("The Goals are:");
        // [] 1. name (descript)
        // 2.
    }
    public void SaveGoals(){
        return;
    }
    public void LoadGoals(){
        return;
    }
    public void RecordEvent(){
        return;
    }
    public abstract void GetGoalDescription();
}