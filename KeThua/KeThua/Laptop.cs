class Laptop : Product {
    public string ram;
    public string chip;
    public Laptop()
    {
        this.Id = 1;
        this.Name = "Acer Nitro 5";
        this.Price = 17800;
        this.ram = "8G";
        this.chip = "Intel Gen 12";
    } 
    public override void info()
    {
        Console.WriteLine("id: " + Id + ", Name: " + Name + ", Price: " + Price + ", ram: " + ram + ", chip: " + chip);
    }
}
