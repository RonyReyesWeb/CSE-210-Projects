using System;

class Program
{
    static void Main(string[] args)
    {
        // USA Customer
        Address address1 = new Address("123 Elm St", "Boise", "ID", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 12.5, 2));
        order1.AddProduct(new Product("Pen", "P123", 1.5, 5));

        // International Customer
        Address address2 = new Address("89 King St", "London", "Greater London", "UK");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N999", 6.0, 3));
        order2.AddProduct(new Product("Backpack", "BP456", 30.0, 1));

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        // Display Order 2
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
