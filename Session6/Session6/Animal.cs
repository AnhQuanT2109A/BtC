class Animal
{
    public void Eat()
    {
        Console.WriteLine("Everyanimal eats somethings. ");
    }
}
class Mammal : Animal
{
    public void Feature()
    {
        Console.WriteLine("Mammals give birth to young ones");
    }
}
class Dog : Mammal
{
    public void Noise()
    {
        Console.WriteLine("DogBarks.");
    }
    static void Main(string[] args)
    {
        Dog objDog = new Dog();
        objDog.Eat();
        objDog.Feature();
        objDog.Noise();
    }
}