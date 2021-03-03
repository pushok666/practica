namespace SexShop.Products
{
    class Condoms : Product
    {
        public int Size { get; set; }

        public Condoms(string name, int price, string manufacturer, int size)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Size = size;
        }
        public override double GetDiscountPrice(User user)
        {
            if (Name[0]=='З')
            {
                Price -= 30;
            }
            return Price;
        }
    }
}
