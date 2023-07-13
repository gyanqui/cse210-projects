using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("Angamos St 125", "San Borja", "Lima", "Peru");
        Customer customer1 = new Customer("Valeria Alcala Guillen", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Graphing Calculator", "GC200", 65.99, 1);
        Product p1002 = new Product("Notebook", "NB50", 3.50, 5);
        Product p1003 = new Product("Mechanical Pencil", "MP05", 1.99, 10);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("352 St", "Good Year", "AZ 85001", "USA");
        Customer customer2 = new Customer("Blake A. Larsen", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Highlighter Set", "HLSET", 4.99, 3);
        Product p2002 = new Product("Index Cards", "IC100", 1.75, 2);
        Product p2003 = new Product("Scientific Calculator", "SCC1000", 12.50, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("2010 W 500 S", "Salt Lake", "UT 84104", "USA");
        Customer customer3 = new Customer("Dario G. Mostacero", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Pencil Case", "PC100", 8.99, 2);
        Product p3002 = new Product("Highlighter Set", "HLSET", 4.99, 4);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}