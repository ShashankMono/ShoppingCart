using ShoppingCart.Models;
using System.Security.Cryptography.X509Certificates;

namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cutomer 1
            Customer customer1 = new Customer(101,"Jack");
            //order 1
            Order customer1Order1 = new Order(151);
            customer1.Orders.Add(customer1Order1);
            LineItem order1item1 = new LineItem(1008,3);
            order1item1.product = new Product(10005,"Bat",5000,10);
            customer1Order1.items.Add(order1item1);

            //order 2
            Order customer1Order2 = new Order(152);
            customer1.Orders.Add(customer1Order2);
            LineItem order2item2 = new LineItem(1010, 5);
            order2item2.product = new Product(100012, "Watch", 1500, 15);
            customer1Order2.items.Add(order2item2);

            Console.WriteLine($"Customer id : {customer1.Id}\n" +
                $"Customer name : {customer1.Name}\n" +
                $"Order count : {customer1.Orders.Count}\n");

            ShowOrders(customer1.Orders);

            
        }
        public static void ShowOrders(List<Order> orders)
        {
            int count = 1;
            double totalCartCost = 0;
            foreach (Order order in orders)
            {
                Console.WriteLine($"Order No : {count++}\n" +
                    $"Order Id : {order.Id}\n" +
                    $"Order Date : {order.Date}\n");
                ShowItems(order.items);
                totalCartCost += order.CalculateOrderPrice();
            }
            Console.WriteLine($"Total cost of the cart : {totalCartCost}");
        }

        public static void ShowItems(List<LineItem> items)
        {
            foreach(LineItem lineItem in items)
            {
                Console.WriteLine($"\nLineItemId : {lineItem.Id}\n" +
                    $"{lineItem.product.ToString()}\n" +
                    $"Quantity : {lineItem.Quantity}\n" +
                    $"TotalCost : {lineItem.CalculateLineItemCost()}\n");
            }
        }
    }
}
