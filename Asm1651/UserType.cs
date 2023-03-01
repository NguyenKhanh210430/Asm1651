namespace Asm1651
{
    abstract class UserType
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public abstract void Display();
        public void ViewAllBook(List<Type> itemlist)
        {
            foreach (var item in itemlist)
            {
                item.Display();
            }
        }
        public void SearchBookByName(List<Type> typelist)
        {
            Console.WriteLine("-------Input-------");
            Console.WriteLine("Enter name: ");
            var Name = Console.ReadLine();
            foreach (var type in typelist)
            {
                if (type.Name.Equals(Name))
                {
                    type.Display();
                }
            }
        }
    }
    class Admin : UserType
    {
        public Admin() { }
        public Admin(string fullName)
        {
            FullName = fullName;
        }

        public override void Display()
        {
            Console.WriteLine($"\nFull Name: {FullName}");
        }
        public void AddAdmin()
        {
            Console.Write("Name: ");
            this.FullName = Console.ReadLine();
        }
        public List<Type> DeleteBook(List<Type> typelist)
        {
            Console.WriteLine("-------Delete Book-------");
            Console.WriteLine("Enter Book Name:");
            string title = Console.ReadLine();
            for (int i = 0; i < typelist.Count; i++)
            {
                if (typelist[i].Name.Equals(title))
                { typelist.RemoveAt(i); }
            }
            return typelist;
        }
        public List<Type> AddBook(List<Type> typelist)
        {
            try
            {
                Console.WriteLine("-------Add Book-------");
                Console.WriteLine($"Enter the type of book you want to add.\n1.Book\n2.Magazine\nYour Option:  ");
                Console.WriteLine("-------Option Choose-------");
                string type = Console.ReadLine();
                if (type.Equals("1", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Write("Book Title: ");
                    string Name = Console.ReadLine();
                    Console.Write("Publication Date: ");
                    string PublicationDate = Console.ReadLine();
                    Console.Write("Price: ");
                    int Price = int.Parse(Console.ReadLine());
                    Console.Write("Author: ");
                    string Author = Console.ReadLine();
                    typelist.Add(new Book(Name, PublicationDate, Price, Author));
                }
                else if (type.Equals("2", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Write("Magazine Title: ");
                    string Name = Console.ReadLine();
                    Console.Write("Year Published: ");
                    string PublicationDate = Console.ReadLine();
                    Console.Write("Price: ");
                    int Price = int.Parse(Console.ReadLine());
                    Console.Write("Artist: ");
                    string Artist = Console.ReadLine();
                    typelist.Add(new Magazine(Name, PublicationDate, Price, Artist));
                }

                else Console.WriteLine("Input error!");
            }
            catch { Console.WriteLine("Please reinput the information"); }
            return typelist;
        }
    }
    class User : UserType
    {
        public User()
        {
        }
        public User(string fullName, string phoneNumber, string address)
        {
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }
        public void AddUser()
        {
            Console.Write("Name: ");
            this.FullName = Console.ReadLine();
            Console.Write("PhoneNum: ");
            this.PhoneNumber = Console.ReadLine();
            Console.Write("Address: ");
            this.Address = Console.ReadLine();
        }
        public override void Display()
        {
            Console.WriteLine($"Full Name: {FullName} \nPhone Num: {PhoneNumber}\nAddress: {Address}");
        }

    }
}

