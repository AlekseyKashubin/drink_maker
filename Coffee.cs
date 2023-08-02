public class Coffee : Drink
{
    public string Roast;
    public string Region;


public override string ShowDrink()
{
    base.ShowDrink();
    return $"Name : {Name} -Color : {Color} -Temp : {Temperature} - Is it Carbonated: {IsCarbonated} -Calories : {Calories} -Roast : {Roast} -Region : {Region}";
}




    public Coffee(string name, string color, double temp, bool isCarb, int calories, string roast, string region)
    : base(name, color, temp, isCarb, calories)
    {
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = false;
        Calories = calories;
        Roast = roast;
        Region = region;
    }
}
