class Program
{
    public static void Main(string[] args)
    {
        Pair<String> pair = new Pair<string>("An", "Nga");
        Console.WriteLine("({0},{1})", pair.First,
        pair.Second);
        Console.ReadLine();
    }
}