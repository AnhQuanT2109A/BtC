class student
{
    public int age;
    public string name;
    public string address;
    static void Main(string[] args)
    {
        student student1 = new student();
         student1.name = "";
         student1.age = 0;
         student1.address = "";
        Console.WriteLine("Student name bofore : " + student1.name);
        Console.WriteLine("Student age bofore : " + student1.age);
        Console.WriteLine("Student address bofore : " + student1.address);
        Console.WriteLine("Changle Value");
        student2(student1);
        Console.WriteLine("Student name after : " + student1.name);
        Console.WriteLine("Student age after : " + student1.age);
        Console.WriteLine("Student address after : " + student1.address);

    }
    public static void student2(student st2)
    {
        st2.name = "Anh Quan";
        st2.age = 19;
        st2.address = "Ha Noi";
    }
}