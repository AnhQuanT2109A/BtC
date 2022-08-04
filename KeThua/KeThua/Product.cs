class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public virtual void info()
    {
        Console.WriteLine("id: " + Id + ", Name: " + Name + ", Price: " + Price);
    }
}