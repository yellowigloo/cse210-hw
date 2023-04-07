using System;

class Program
{
    static void Main(string[] args)
    {
        Order ord1 = new Order();
        Customer cust1 = new Customer();
        cust1.SetName("Jeff");
        Address addy1 = new Address();
        addy1.SetStreetAddress("123 Ball St");
        addy1.SetCity("Austin");
        addy1.SetState("TX");
        addy1.SetCountry("USA");
        cust1.SetAddress(addy1);
        ord1.SetCustomer(cust1);
        Product prod1Cust1 = new Product();
        prod1Cust1.SetName("Pickle");
        prod1Cust1.SetProductId("124321");
        prod1Cust1.SetPrice(2);
        prod1Cust1.SetQuantity(5);
        Product prod2Cust1 = new Product();
        prod2Cust1.SetName("Lettuce");
        prod2Cust1.SetProductId("123432");
        prod2Cust1.SetPrice(3);
        prod2Cust1.SetQuantity(2);
        List<Product> prods1 = new List<Product>();
        prods1.Add(prod1Cust1);
        prods1.Add(prod2Cust1);
        ord1.SetProductList(prods1);
        ord1.DisplayPackingLabel();
        ord1.DisplayShippingLabel();
        ord1.CalculateTotalCost();
    }
}