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

        // calculate price of products
        foreach (Product p in _products) {
            double price = p.CalculatePrice();
            totalprice += price;
        }

        // calculate shipping cost
        double shippingCost = CalculateShipping();

        // calculate total price with shipping cost
        totalprice += shippingCost;

        return totalprice;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "PACKING LABEL\n";

        foreach (Product p in _products) {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }

        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel = "SHIPPING LABEL\n";

        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress();
        
        return shippingLabel;
    }

    public string GenerateTotalCost()
    {
        string totalCost = "\nTOTAL COST:\n";
        double totalPrice = CalculateTotalPrice();
        foreach (Product p in _products) {
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        totalCost += "Shipping Cost: " + "$" + CalculateShipping() + "\n";
        totalCost += "TOTAL COST: $" + CalculateTotalPrice();
        
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
        Console.WriteLine("--------END OF ORDER---------");
    }
}