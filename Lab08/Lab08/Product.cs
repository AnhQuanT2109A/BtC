using System;
class Product
{
    private string name;
    private double cost;
    private int onhand;
    public Product(string n, double c, int h)
    {
        name = n;
        cost = c;
        onhand = h;
    }
    public override string ToString()
    {
        return String.Format("{0, -10}Cost: {1,6:C} On hand: {2}  ", name, cost, onhand);

    }
}