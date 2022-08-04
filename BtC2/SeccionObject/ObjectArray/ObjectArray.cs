class Employee
{
    private int empID;
    public Employee(int empID)
    {
        this.empID = empID;
    }
    public override string ToString()
    {
        return empID.ToString();
    }
}
class objectArray
{
    public void Run()
    {
        int[] intArray;
        Employee[] empArray;
        intArray = new int[5];
        empArray = new Employee[3];

        for (int i = 0; i < empArray.Length; i++)
        {
            empArray[i] = new Employee(i + 5);
        }
        Console.WriteLine("The int array...");
        for (int i = 0; i < empArray.Length; i++)
        {
            Console.WriteLine(empArray[i].ToString());
        }
        Console.WriteLine("\nThe employee array...");
        for (int i = 0; i < empArray.Length; i++)
        {
            Console.WriteLine(empArray[i].ToString());
        }
    }
    static void Main(string[] args)
    {
        objectArray arr = new objectArray();
        arr.Run();
        Console.ReadLine();
    }
}