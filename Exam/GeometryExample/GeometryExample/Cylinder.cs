class Cylinder {
    static void Main(String[] args) {
        //Process
        Console.WriteLine("Enter the dimenstions of the cylinder");
        Console.Write("Radius : " );
        double Radius = double.Parse(Console.ReadLine());
        Console.Write("Height : ");
        double Height = double.Parse(Console.ReadLine());

        //Result
        Console.WriteLine("\nCylinder Characteristics");
        Console.WriteLine("Radius: "+Radius+", Height: "+Height);
        double BaseArea = Radius * Radius * Math.PI;
        double LateralArea = 2 * Math.PI * Radius * Height;
        double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        double Volume = Math.PI * Radius * Radius * Height;
        Console.WriteLine("Base: " + Math.Round(BaseArea,2) + " | Latera: " + Math.Round(LateralArea ,2) + " | Total: " +Math.Round(TotalArea ,2) + " | Volume: " +Math.Round(Volume ,2));
    }
}