class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _waitTime;
    public Activity(string name, string description, int duration, int waitTime){
        _name = name;
        _description = description;
        _duration = duration;
        _waitTime = waitTime;
    }
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetDuration(){
        return _duration;
    }
    public int GetWaitTime(){
        return _waitTime;
    }
    public void StartWaiting(){
        Console.WriteLine($"How long do you want to do {_name}?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"{_description}");
        Waiting();
    }
    public void Waiting(){
        Console.WriteLine("|");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        for (int i = 0; i < _waitTime; i++){
            if ((i % 4) == 1){
                Console.WriteLine("/");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            else if ((i % 4) == 2){
                Console.WriteLine("--");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            else if ((i % 4) == 3){
                Console.WriteLine("\\");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            else if ((i % 4) == 4){
                Console.WriteLine("|");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        }
        public void EndAct(){
        Console.WriteLine("Wait for activity to end");
        Console.WriteLine($"Congrats on completing {_name}, for {_duration} seconds");
        Waiting();
        // Time and spiner
        }

}