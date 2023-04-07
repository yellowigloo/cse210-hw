class Order{
    List<Product> _products = new List<Product>();
    Customer _customer;
    public void CalculateTotalCost(){
        int total = 0;
        foreach (Product product in _products){
            total += product.GetTotalPrice();
        }
        if (_customer.USALiving()){
            total += 5;
        }
        else{
            total += 35;
        }
        Console.WriteLine($"${total} total");
    }
    public void SetCustomer(Customer customer){
        _customer = customer;
    }
    public void SetProductList(List<Product> prods){
        _products = prods;
    }
    public void DisplayPackingLabel(){
        Console.WriteLine($"{_customer.GetName()}\nProduct IDs:");
        foreach (Product product in _products){
            Console.WriteLine($"{product.GetId()}");
        }
    }
    public void DisplayShippingLabel(){
        Console.WriteLine($"{_customer.GetAddress()}");
    }
}