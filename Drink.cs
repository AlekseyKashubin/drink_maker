
public class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;

    // We need a basic constructor that takes all these features in
    public Drink(string name, string color, double temp, bool isCarb, int calories)
    {
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = isCarb;
        Calories = calories;
    }


    public virtual string ShowDrink()
    {
        return $"Name : {Name} -Color :{Color} -Temp :{Temperature} - Is it Carbonated:{IsCarbonated} -Calories :{Calories} ";
        // Console.WriteLine($"Name :{Name}");
        // Console.WriteLine($"Color :{Color}");
        // Console.WriteLine($"Temp :{Temperature}");
        // Console.WriteLine($"Is it Carbonated:{IsCarbonated}");
        // Console.WriteLine($"Calories :{Calories}");
    }
}

