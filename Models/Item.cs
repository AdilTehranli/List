namespace ConsoleApp6.Models;

public class Item
{
    public string Name { get; set; }
    public double Cost { get; set; }

    public Item(string name, double cost)
    {
        Name = name;
        Cost = cost;
    }
}
