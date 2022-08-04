class Metals
{
    string _metalType;
    public Metals(string type)
    {
        _metalType = type;  
        Console.WriteLine("Metal: \t\t" + _metalType);
    }
}
class SteelCompany:Metals
{
    string _grade;
    public SteelCompany(string grade) : base("Steel")
    {
        _grade = grade;
        Console.WriteLine("Grade: \t\t"+_grade);
    }
}
class Automobiles : SteelCompany
{
    string _part;
    public Automobiles(string part) : base("Cart Iron")
    {
        _part = part;
        Console.WriteLine("Part: \t\t" + _part);
    }
    static void Main(string[] arhs)
    {
        Automobiles objAutomobiles = new Automobiles("Chassies");
    }
}