class Event{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    Address _address;
    public void DisplayStdDetails(){
        Console.WriteLine($"{_title}\n{_description}\n{_date}{_time}\n{_address.GetCity()} {_address.GetStreet()} ");
    }
    public void DisplayShortDescript(){
        Console.WriteLine($"{_title}\n{_date}");
    }
    public void SetTitle(string title){
        _title = title;
    }
    public void SetDescription(string descript){
        _description = descript;
    }
    public void SetDate(string date){
        _date = date;
    }
    public void SetTime(string time){
        _time = time;
    }
    public void SetAddress(Address address){
        _address = address;
    }
}