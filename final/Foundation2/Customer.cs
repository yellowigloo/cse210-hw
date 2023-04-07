class Customer{
    string _name;
    Address _address;
    public Boolean USALiving(){
        return _address.GetUSALiving();
    }
    public string GetAddress(){
        return _address.GetAddress();
    }
    public string GetName(){
        return _name;
    }
    public void SetName(string name){
        _name = name;
    }
    public void SetAddress(Address address){
        _address = address;
    }
}
