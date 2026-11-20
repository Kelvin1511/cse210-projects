using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer - $5 shipping)
        Address address1 = new Address("450 N University Ave", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Rich Kevin Panozo Vargas", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mechanical Keyboard", "KB-101", 79.99, 1));
        order1.AddProduct(new Product("Ergonomic Gaming Mouse", "MS-204", 35.50, 2));
        order1.AddProduct(new Product("USB-C Hub Adapter", "HB-309", 24.00, 1));

        // Order 2 (International Customer - $35 shipping)
        Address address2 = new Address("Av. Larco 1150, Miraflores", "Lima", "Lima", "Peru");
        Customer customer2 = new Customer("Mateo Quispe", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Noise Cancelling Headphones", "HP-502", 149.99, 1));
        order2.AddProduct(new Product("Laptop Stand Aluminum", "LS-118", 29.95, 2));

        // Display Order 1
        Console.WriteLine("==================================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("==================================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================\n");

        // Display Order 2
        Console.WriteLine("==================================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("==================================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================");
    }
}