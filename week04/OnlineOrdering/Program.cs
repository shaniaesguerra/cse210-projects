using System;

class Program
{
    static void Main(string[] args)
    {
        //Make customers and addresses
        Address customerAddress1 = new Address("Able Street", "Nook City", "TurnipVille", "USA");
        Customer customer1 = new Customer("Daisy Mae", customerAddress1);

        Address customerAddress2 = new Address("Timmy Nook Avenue", "Slider City", "OldYorkVille", "Canada");
        Customer customer2 = new Customer("K.K Slider", customerAddress2);

        List<Product> products1 = new List<Product>();
        List<Product> products2 = new List<Product>();

        //make products
        Product product1 = new Product("Oreo Standard Pack", "0RC100", 6.00, 5);
        Product product2 = new Product("All-Purpose Flour (2.5kg)", "APF200", 5.99, 1);
        Product product3 = new Product("Large Eggs (30pcs)", "EGP201", 8.30, 2);
        Product product4 = new Product("Whole Milk (2L)", "MLK1202", 4.99, 4);
        Product product5 = new Product("Sliced White Bread", "BRD210", 2.97, 2);
        Product product6 = new Product("Salted Butter (250g)", "BTR1203", 5.98, 3);

        //add products
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);
        products2.Add(product4);
        products2.Add(product5);
        products2.Add(product6);

        Order orderTicket1 = new Order(products1, customer1);
        Order orderTicket2 = new Order(products2, customer2);

        Console.WriteLine("Order Ticket 1:");
        orderTicket1.MakePackingLabel();
        double orderTotal = orderTicket1.GetTotalPrice();
        Console.WriteLine($"TOTAL: ${orderTotal}");
        Console.WriteLine();
        orderTicket1.MakeShippingLabel();
        Console.WriteLine();

        Console.WriteLine("Order Ticket 2:");
        orderTicket2.MakePackingLabel();
        orderTotal = orderTicket2.GetTotalPrice();
        Console.WriteLine($"TOTAL: ${orderTotal}");
        Console.WriteLine();
        orderTicket2.MakeShippingLabel();
        Console.WriteLine();

    }
}