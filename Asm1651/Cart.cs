namespace Asm1651
{
    internal class Cart
    {
        public int Total;
        public List<Type> types = new List<Type>();
        public User user;
        public Purchase cash;
        public Cart(User user)
        {
            this.user = user;
        }
        public void AddType(List<Type> typelist, string name)
        {
            foreach (var type in typelist)
                if (type.Name.Equals(name))
                    types.Add(type);
            TotalCost();
        }
        public void RemoveType(List<Type> typelist, string name)
        {
            foreach (var type in typelist)
                if (type.Name.Equals(name))
                    types.Remove(type);
            TotalCost();
        }
        public void TotalCost()
        {
            int total = 0;
            foreach (var type in types)
            {
                total += type.Price;
            }
            this.Total = total;
        }
        public void Purchase()
        {
            Console.Write($"Total: {Total}");
            {
                Console.Write(" | Pay by cash, amount: ");
                int number = int.Parse(Console.ReadLine());
                if (Total <= number)
                {
                    cash = new Cash(number, Total);
                    string str = "";
                    foreach (var type in types)
                    {
                        str += type.Name + " ";
                    }
                    Console.WriteLine($"Book: {str}\nPayment: {cash}");
                    Console.WriteLine($"Success!");
                }
                else Console.WriteLine("Paid amount cant be lower than the total price");
            }
        }
    }
}
