namespace SexShop
{
    class User
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }
        public string Sex { get; set; }

        public User(string name, string adress, int balance, int spent,string sex)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Spent = spent;
            Sex = sex;
        }

        public void ReduceBalance(double price)
        {
            Balance -= price; 
            Spent += price; 
        }
    }
}
