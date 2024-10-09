using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPrecent {  get; set; }

        public Product(int id,string name,double price,double discount)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPrecent = discount;
        }

        public double CalculateDiscountedPrice()
        {
            return (Price - (Price * (DiscountPrecent / 100)));
        }

        public override string ToString()
        {
            return $"Product Id : {Id}\n" +
                $"Product unit price : {Price}\n" +
                $"Product name : {Name}\n" +
                $"Product discount : {DiscountPrecent}%\n" +
                $"Price After discount : {CalculateDiscountedPrice()}\n";
        }
    }
}
