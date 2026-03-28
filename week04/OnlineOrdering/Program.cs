using System;

class Program
{
    static void Main(string[] args)
    {
       Address address1 = new Address("1234 Happy St","Cookeville", "TN", "USA");
       Customer customer1 = new Customer("Erica Kimball", address1);

       Product product1 = new Product ("Organic Diaper","OD01", 14.99, 2);
       Product product2 = new Product ("Clean Conscious Wipes", "CCW02", 5.99, 3);

       Order order1 = new Order(customer1);
       order1.AddProduct(product1);
       order1.AddProduct(product2);

       Console.WriteLine("ORDER 1");
       Console.WriteLine("Packing Label:");
       Console.WriteLine(order1.GetPackingLabel());
       Console.WriteLine("Shipping Label:");
       Console.WriteLine(order1.GetShippingLabel());
       Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

       Console.WriteLine();

       Address address2 = new Address("456 Citizen St", "Toronto", "ON", "Canada");
       Customer customer2 = new Customer("John Doe", address2);

       Product product3 = new Product("Cell Phone Repair Kit", "RK101", 39.99, 1);
       Product product4 = new Product("iPhone 12 Screen Protector", "SP115", 15.99, 1);
       Product product5 = new Product("Otter Box Durable Phone Case", "OPB016",49.99, 1); 

       Order order2 = new Order(customer2);
       order2.AddProduct(product3);
       order2.AddProduct(product4);
       order2.AddProduct(product5);

       Console.WriteLine("ORDER 2");
       Console.WriteLine("Packing Label:");
       Console.WriteLine(order2.GetPackingLabel());
       Console.WriteLine("Shipping Label:");
       Console.WriteLine(order2.GetShippingLabel());
       Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");

       Console.WriteLine();
    }
}