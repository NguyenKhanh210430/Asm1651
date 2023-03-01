namespace Asm1651
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            List<Type> typelist = new List<Type>();
            List<Cart> orders = new List<Cart>();
            List<User> users = new List<User>();
            User user = new User();
            Cart order = new Cart(user);
            Admin admin = new Admin();
            typelist.Add(new Book("The Midnight Library", "08/28/2020", 25, "Matt Haig"));
            typelist.Add(new Book("Don Quixote", "01/01/1605", 50, "Miguel de Cervantes"));
            typelist.Add(new Magazine("Real Simple", "08/28/2020", 30, "Meredith Corporation"));
            typelist.Add(new Magazine("Family Handyman", "05/15/2021", 22, "Trusted Media Brands, Inc"));
            do
            {
                Console.WriteLine("-------Role Select-------");
                Console.WriteLine($"Please select your role:\n1.Admin\n2.User\n3.Exit Program\nChoose your option: ");
                Console.WriteLine("-------Option Choose-------");
                option = Console.ReadLine();
                if (option.Equals("1"))
                {
                    Console.WriteLine("-------End-------");
                    Console.Write($"Please enter a password to proceed\nPassword: ");
                    string password = Console.ReadLine();
                    do
                        if (password.Equals("admin"))
                        {
                            int x;
                            do
                            {
                                Console.WriteLine("-------Admin Menu-------");
                                Console.WriteLine($"1:View available book & magazine\n2:Search book by name\n3:Add new book \n4:Delete book\n5:Back\n6:Exit Program");
                                Console.WriteLine("Choose your option: ");
                                Console.WriteLine("-------Option Choose-------");
                                x = int.Parse(Console.ReadLine());
                                switch (x)
                                {
                                    case 1:
                                        admin.ViewAllBook(typelist);
                                        break;
                                    case 2:
                                        admin.SearchBookByName(typelist);
                                        break;
                                    case 3:
                                        admin.AddBook(typelist);
                                        break;
                                    case 4:
                                        admin.DeleteBook(typelist);
                                        break;
                                    case 6:
                                        Console.WriteLine("-------End-------");
                                        Console.WriteLine("Good Bye!");
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        break;
                                }
                            } while (x != 5);
                        }
                        else Console.WriteLine("Wrong Password!");
                    while (!option.Equals("Back"));
                }
                else if (option.Equals("2"))
                {
                    int x;
                    do
                    {
                        Console.WriteLine("-------User Menu-------");
                        Console.WriteLine($"1:View available book\n2:Find book by name\n3:Add book to order\n4:Remove book from order\n5:Check out\n6:Back to Menu\n7:Exit Program.");
                        Console.WriteLine("Choose your option:");
                        Console.WriteLine("-------Option Choose-------");
                        x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1:
                                user.ViewAllBook(typelist);
                                break;
                            case 2:
                                user.SearchBookByName(typelist);
                                break;
                            case 3:
                                Console.WriteLine("Enter book name: ");
                                string Addname = Console.ReadLine();
                                order.AddItem(typelist, Addname);
                                break;
                            case 4:
                                Console.WriteLine("Enter book name: ");
                                string Removename = Console.ReadLine();
                                order.RemoveItem(typelist, Removename);
                                break;
                            case 5:
                                Console.WriteLine("-------End-------");
                                user.AddUser();
                                order.Purchase();
                                orders.Add(order);
                                break;
                            case 7:
                                Console.WriteLine("-------End-------");
                                Console.WriteLine("Good Bye!");
                                Environment.Exit(0);
                                break;

                            default:
                                break;
                        }
                    } while (x != 6);
                }
                else if (option.Equals("3"))
                {
                    Console.WriteLine("-------End-------");
                    Console.WriteLine("Good Bye!");
                    Environment.Exit(0);
                }

            } while (!option.Equals(" "));
        }
    }
}


