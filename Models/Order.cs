using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> items { get; set; } = new List<LineItem>();
        

        public Order(int id) { 
            Id = id;
            Date = DateTime.Now;
        }

        public double CalculateOrderPrice()
        {   
            double totalPrice = 0;
            foreach (LineItem item in items)
            {
                totalPrice += item.CalculateLineItemCost();
            }
            return totalPrice;
        }
    }
}
