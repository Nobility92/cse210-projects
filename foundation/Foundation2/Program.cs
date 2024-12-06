using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Samsung Phone", "SAM001", 500.00m, 1);
        Product product2 = new Product("Charger", "CH002", 5.00m, 2);

        Product product3 = new Product("Washing Machine", "WA003", 1250.00m, 1);
        Product product4 = new Product("Freezer", "FR004", 820.00m, 1);

        // Create addresses
        Address address1 = new Address("20B Okeremi St", "Ibadan", "OY", "NGN");
        Address address2 = new Address("2 Amisu St", "Lagos", "LAG", "NGN");

        // Create customers
        Customer customer1 = new Customer("Henry Nwaokonko", address1);
        Customer customer2 = new Customer("Wendy Nwaokonko", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
