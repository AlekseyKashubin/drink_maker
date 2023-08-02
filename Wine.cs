public class Wine : Drink
{
    public string Region;
    public int Year;




public override string ShowDrink()
{
    base.ShowDrink();
    return $"Name : {Name} -Color : {Color} -Temp : {Temperature} - Is it Carbonated: {IsCarbonated} -Calories : {Calories} -Region : {Region} -Year : {Year}";
}




    public Wine(string name, string color, double temp, bool isCarb, int calories, string region, int year)
    : base(name, color, temp, isCarb, calories)
    {
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = isCarb;
        Calories = calories;
        Region = region;
        Year = year;
    }
}