using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Order 1
        Address address1 = new Address("Av. Cesar Vallejo 2145", "San Isidro", "Lima", "Peru");

        Customer customer1 = new Customer("Maria Perez", address1);

        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Steel Tape", "ST200", 10.30, 1);
        Product p1002 = new Product("18-inch Ruler", "RUL18", 5.00, 3);
        Product p1003 = new Product("PVC Glue 200ml", "PVCG200", 1.25, 5);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);
        
        Console.WriteLine("Order #1");
        order1.DisplayResults();
        Console.WriteLine();

        Address address2 = new Address("Javier Prado 516", "La Molina", "Lima", "Peru");
        
        Customer customer2 = new Customer("Juan Torres", address2);
        
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("A4 Ream", "A4500", 6, 7);
        Product p2002 = new Product("Box of 12 Pens", "PT12", 3.75, 1);
        Product p2003 = new Product("2-inch Masking Tape", "SMT-2", 1.60, 4);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);
        
        Order order2 = new Order(productsList2, customer2);
        
        Console.WriteLine("Order #2");
        order2.DisplayResults();
        Console.WriteLine();

        Address address3 = new Address("3743 Woodrow Way", "Madisonville", "TX 77864", "USA");
        
        Customer customer3 = new Customer("Pedro Lopez", address3);
        
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("A4 Ream", "A4500", 6, 25);
        Product p3002 = new Product("1/4 Illustration Board", "IB25", 0.25, 25);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order #3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}
