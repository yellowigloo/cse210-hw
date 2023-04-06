class ListingAct : Activity
{
    public ListingAct(string name, string description, int duration, int waitTime) : base(name, description, duration, waitTime){
        return;
    }
    public string GetPrompt(){
        Random rnd = new Random();
        int randomPrompt = rnd.Next(4);
        if (randomPrompt == 0){
            return "Who are people that you appreciate?";
        }
        else if (randomPrompt == 1){
            return "What are personal strengths of yours?";
        }
        else if (randomPrompt == 2){
            return "Who are people that you have helped this week?";
        }
        else if (randomPrompt == 3){
            return "When have you felt the Holy Ghost this month?";
        }
        else if (randomPrompt == 4){
            return "Who are some of your personal heroes?";
        }
        return "";
    }
    public void Listing(){
        StartWaiting();
        int i = 0;
        DateTime currentTime = DateTime.Now;
        string prompt = GetPrompt();
        Waiting();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        while (currentTime < futureTime){
        i++;
        Console.WriteLine($"{prompt}");
        Console.ReadLine();
        currentTime = DateTime.Now;
        }
        Console.WriteLine($"You gave {i} responses!");
        EndAct();
    }

}