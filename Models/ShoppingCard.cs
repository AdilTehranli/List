namespace ConsoleApp6.Models;

public class ShoppingCard:IOperation
{
    public double TotalCost  { get; set; }
    public Item[] items =new Item[0];
    public void Add(Item item)
    {
      
            Array.Resize(ref items,items.Length+1);
            items[items.Length-1] = item;
        TotalCost += item.Cost;
        
    }
    public void Remove(Item item)
    {
        Item[] temp= new Item[items.Length-1];
        int ind = 0;
        for (int i = 0; i <items.Length; i++)
        {
            if (items[i].Name == item.Name)
            {
                continue;
            }
            temp[ind] = items[i];
            ind++;
        }
        items= temp;
        TotalCost-= item.Cost;
    }
}
