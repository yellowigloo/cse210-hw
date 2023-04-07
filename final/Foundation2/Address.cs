class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Boolean GetUSALiving(){
        if (_country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }
    public void SetStreetAddress(string address){
        _streetAddress = address;
    }
    public void SetCity(string city){
        _city = city;
    }
    public void SetState(string state){
        _state = state;
    }
    public void SetCountry(string country){
        _country = country;
    }
    public string GetAddress(){
        // List<string> address = new List<string>();
        // address.Add(_streetAddress);
        // address.Add(_city);
        // address.Add(_state);
        // address.Add(_country);
        string address = $"{_streetAddress}\n{_city}, {_state}, {_country}";
        return address;
        // Console.WriteLine($"{_streetAddress}\n{_city}, {_state}, {_country}");
    }
}