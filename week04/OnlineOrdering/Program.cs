using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("1324 central ave", "phoenix", "AZ", "USA");
        Address address2 = new Address("2319 Maple RD", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John smith", address1);
        Customer customer2 = new Customer("jesus christ", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("gold plates", "A123", 999.99, 1));
        order1.AddProduct(new Product("translator", "B456", 29.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("carpenter table", "C789", 499.99, 1));
        order2.AddProduct(new Product("donkey", "D012", 89.99, 1));
        order2.AddProduct(new Product("shepherd cloths", "E345", 59.99, 1));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
