public class Soda : Drink
{
    public bool IsDiet;



public override string ShowDrink()
{
    base.ShowDrink();
    return $"Name : {Name} -Color : {Color} -Temp : {Temperature} - Is it Carbonated: {IsCarbonated} -Calories : {Calories} -Is it Diet : {IsDiet}";
}



    public Soda(string name, string color, double temp, bool isCarb, int calories, bool isDiet) 
    : base(name, color, temp, isCarb, calories)
    {
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = true;
        Calories = calories;
        IsDiet = isDiet;

    }
}