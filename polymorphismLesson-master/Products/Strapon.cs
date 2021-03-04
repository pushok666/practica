using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SexShop.Products;

namespace SexShop.Products
{
    class Strapon:Product
    {
        public int Size { get; set; }
        public Strapon(string name, int price, string manufacturer, int size)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Size = size;
        }
        public override double GetDiscountPrice(User user)
        {
            if (user.Sex == "men")
            {
                Console.WriteLine("для таких геев как вы, {0} у нас скидка 50 процентов", user.Name);
                Price = Price / 2;
            }
            return Price;
        }


    }
}
