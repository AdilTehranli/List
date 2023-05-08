using System.Reflection.Emit;

namespace ConsoleApp6.Models;

public class CostumList<T>
{
	public T[] Values;
	public int Count { get; set; }
	public int Capacity { get; set; }
	public CostumList()
	{
		Values= new T[0];
        Count= 0;
		Capacity= 0;
    }
	public void Add(T value)
	{
		if (Values.Length == 0)
		{
			Capacity= 4;
			
			
		}
		else
		{
		
			if(Count== Capacity)
			{
				Capacity *= 2;
			}
			
		}
        Array.Resize(ref Values, Capacity);
        Values[Count] = value;
        Count++;
	}
}
