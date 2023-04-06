class ReflectionAct : Activity
{
    string[] prompts = new string[]{"Think of a time when you stood up for someone else."
        ,"Think of a time when you did something really difficult."
        ,"Think of a time when you helped someone in need."
        ,"Think of a time when you did something truly selfless."};
    string[] promptQs = new string[]{"How did it make you feel?"
        ,"Why did you do it?"
        ,"How often do you do those things?"};

    public ReflectionAct(string name, string description, int duration, int waitTime) : base(name, description, duration, waitTime){
        return;
    }
    public string ShowPrompt(){
        Random rnd = new Random();
        int randomPrompt = rnd.Next(4);
        string prompt = prompts[randomPrompt];
        return prompt;
    }
    public string PromptReflect(){
        Random rnd = new Random();
        int randomPromptQ = rnd.Next(4);
        string promptQ = promptQs[randomPromptQ];
        return promptQ;
    }
    public void Reflecting(){
        StartWaiting();
        for (int i = 0; i < GetDuration()/(2*GetWaitTime()); i++){
        ShowPrompt();
        Waiting();
        PromptReflect();
        Waiting();
        }
        EndAct();
    }

}