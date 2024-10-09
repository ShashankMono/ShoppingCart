using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class LineItem
    {
        public int Id { get; set; }
        public int Quantity {  get; set; }
        public Product product { get; set; }

        public LineItem(int id,int quantity) { 
            Id = id;
            Quantity = quantity;
        }

        public double CalculateLineItemCost()
        {
            return (product.CalculateDiscountedPrice() * Quantity);
        }
    }
}
