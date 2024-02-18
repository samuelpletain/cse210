using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Chicago", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Barbie Dolls", "BAR_123", 123, 3);
        Product product2 = new Product("Ipad", "24012331", 456, 1);
        Product product3 = new Product("Vaccum Bags", "DYSON-5123-23", 3.99, 10);
        Product product4 = new Product("Laptop", "LAP_123.00", 1299, 1);
        Product product5 = new Product("Headphones", "sony.789", 99.99, 1);
        Product product6 = new Product("Socks", "123122", 9.99, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($"Order {i + 1}");
            Console.WriteLine();
            Console.WriteLine("Packing Label:");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${string.Format("{0:.00}", orders[i].GetTotalCost())}");
            Console.WriteLine();
            if (i != orders.Count - 1)
            {
                Console.WriteLine("==================================");
                Console.WriteLine();
            }
        }
    }
}