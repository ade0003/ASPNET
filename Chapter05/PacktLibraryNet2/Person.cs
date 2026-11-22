namespace Packt.Shared;
public class Person
{
    public string? Name;
    public DateTimeOffset Born;

    public List<Person> Children = new();

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        
        z = 100;
        w++;
        y++;
        z++;

        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    public void ParamsParameters(string text, params int[] numbers)
    {
        int total = 0;
        foreach(int number in numbers)
        {
            
            total+=number;
        }
        WriteLine($"{text}: {total}");

    }

    public (string Name, int Count) GetFruit()
    {
        
        return(Name: "Apples", Count: 2);
    }

}