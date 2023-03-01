namespace Asm1651
{
    class Type
    {
        public string Name { get; set; }
        public string PublicationDate { get; set; }
        public int Price { get; set; }
        public Type() { }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name} \nPublication Date: {PublicationDate} \nPrice: {Price}");
        }
    }
    class Book : Type
    {
        private string Author { get; set; }
        public Book() { }
        public Book(string name, string publicationdate, int price, string author)
        {
            this.Name = name;
            this.PublicationDate = publicationdate;
            this.Price = price;
            this.Author = author;
        }
        public override void Display()
        {
            Console.WriteLine("-------Book Info-------");
            Console.WriteLine($"Book Name: {Name} \nPublication Date: {PublicationDate} \nBook Price: {Price}\nBook Author: {Author}");
        }
    }
    class Magazine : Type
    {
        private string Publisher { get; set; }
        public Magazine() { }
        public Magazine(string name, string publicationdate, int price, string publisher)
        {
            this.Name = name;
            this.PublicationDate = publicationdate;
            this.Price = price;
            this.Publisher = publisher;
        }
        public override void Display()
        {
            Console.WriteLine("-------Magazine Info-------");
            Console.WriteLine($"Magazine Name: {Name} \nPublication Date: {PublicationDate} \nMagazine Price: {Price}\nMagazine Publisher: {Publisher}");
        }
    }
}
