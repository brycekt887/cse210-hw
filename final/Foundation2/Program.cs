using System;

class Program2
{
    static void Main(string[] args)
    {
        // first order  USA customer
        Address addr1 = new Address("789 Campus Dr", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Bryce Taylor", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Mechanical Keyboard", "KB-100", 85.0, 1));
        order1.AddProduct(new Product("USB-C Cable", "CB-12", 9.99, 2));

        // second order non nUSA customer
        Address addr2 = new Address("12 Maple Lane", "London", "LDN", "UK");
        Customer cust2 = new Customer("Emily Parker", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Laptop Stand", "LS-33", 40.0, 1));
        order2.AddProduct(new Product("Wireless Mouse", "WM-8", 25.5, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order Total: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order Total: $" + order2.GetTotalCost());
    }
}
