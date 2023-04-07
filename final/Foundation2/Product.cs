class Product{
    string _name;
    string _productId;
    int _price;
    int _quantity;
    public int GetTotalPrice(){
        return _price * _quantity;
    }
    public string GetId(){
        return _productId;
    }
    public void SetName(string name){
        _name = name;
    }
    public void SetProductId(string id){
        _productId = id;
    }
    public void SetPrice(int price){
        _price = price;
    }
    public void SetQuantity(int quantity){
        _quantity = quantity;
    }
}