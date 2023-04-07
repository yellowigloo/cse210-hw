class OutdoorGath : Event{
    private string _type;
    private string _dress;
    public void DisplayFullDets(){
        DisplayStdDetails();
        Console.WriteLine($"We are having a {_type} gathering, join us\n{_dress} clothes suggested");
    }
    public void SetType(string type){
        _type = type;
    }
    public void SetDress(string dress){
        _dress = dress;
    }
}