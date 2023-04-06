class BreathingAct : Activity
{
    int _breathTime;
    public BreathingAct(string name, string description, int duration, int waitTime, int breathTime) : base(name, description, duration, waitTime){
        _breathTime = breathTime;
    }
    public void Breathing(){
        StartWaiting();
        // base.Waiting();
        for (int i = 0; i < GetDuration()/_breathTime; i++){
            Console.WriteLine("Breathe in...");
            for (int j = 0; j < _breathTime; j++){
                Console.WriteLine($"{_breathTime - j}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Breathe out...");
            for (int j = 0; j < _breathTime; j++){
                Console.WriteLine($"{_breathTime - j}");
                Thread.Sleep(1000);
            }
        }
        EndAct();
    }

}