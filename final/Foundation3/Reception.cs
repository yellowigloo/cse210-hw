class Reception : Event{
    private string _couple;
    public void DisplayFullDets(){
        DisplayStdDetails();
        Console.WriteLine($"The {_couple} couple are soon to be married, come join us family!!!");
    }
    public void SetCouple(string coup){
        _couple = coup;
    }
}