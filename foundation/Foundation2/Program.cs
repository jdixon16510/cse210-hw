using System;

class Program
{
    static void Main()
    {
        // The first order
        var address1 = new Address("123 Main St", "New York", "NY", "USA");
        var customer1 = new Customer("John Doe", address1);
        var order1 = new Order(customer1);
        
        var product1 = new Product("Laptop", 101, 999.99, 1);
        var product2 = new Product("Mouse", 102, 25.50, 2);
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Displaying order details for the first order
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice()}\n");

        // The second order
        var address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);
        var order2 = new Order(customer2);
        
        var product3 = new Product("Phone", 103, 499.99, 1);
        var product4 = new Product("Headphones", 104, 79.99, 1);
        
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Displaying order details for the second order
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}\n");
    }
}