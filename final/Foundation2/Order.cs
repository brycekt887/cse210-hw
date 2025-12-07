using System.Collections.Generic;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        double shipping;

        if (customer.LivesInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string result = "Packing Label:\n";

        foreach (Product p in products)
        {
            result += "- " + p.GetName() + " (ID: " + p.GetId() + ")\n";
        }

        return result;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetName() + "\n" +
               customer.GetAddress().GetFullAddress();
    }
}
