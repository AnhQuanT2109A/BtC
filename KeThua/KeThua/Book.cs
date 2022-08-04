class Book : Product {
    public string BookName;

    public Book()
    {
        this.Id = 2;
        this.Name = "Xuan Dieu";
        this.Price = 0;
        this.BookName = "Yeu";
    }
    public override void info()
    {
        Console.WriteLine("id: " + Id + ", Name: " + Name + ", Price: " + Price + ", NameBook: " + BookName);
    }
}
