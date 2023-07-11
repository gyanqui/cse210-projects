using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateShipping()
    {
        double shippingCost = 0;
        if (_customer.isFromUSA() == true) {
            shippingCost = 5;
        } else {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        foreach (Product p in _products) {
            double price = p.CalculatePrice();
            totalprice += price;
        }

        double shippingCost = CalculateShipping();

        totalprice += shippingCost;

        return totalprice;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label\n";

        foreach (Product p in _products) {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }

        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label\n";

        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress();
        
        return shippingLabel;
    }

    public string GenerateTotalCost()
    {
        string totalCost = "\nTotal Cost:\n";
        double totalPrice = CalculateTotalPrice();
        foreach (Product p in _products) {
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() ;
        }
        totalCost += "Shipping Cost: " + "$" + CalculateShipping();
        totalCost += "Total: $" + CalculateTotalPrice();
        
        return totalCost;
    }

    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel();
        string shippingLabel = GenerateShippingLabel();
        string totalCost = GenerateTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
        Console.WriteLine("------- Order Completed --------");
    }
}