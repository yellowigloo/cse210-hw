class Lecture : Event{
    private string _speaker;
    private string _topic;
    public void DisplayFullDets(){
        DisplayStdDetails();
        Console.WriteLine($"{_speaker}\n{_topic}");
    }
    public void SetSpeaker(string speaker){
        _speaker = speaker;
    }
    public void SetTopic(string topic){
        _topic = topic;
    }
}