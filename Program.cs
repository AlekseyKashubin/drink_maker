// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Soda soda = new Soda("Crush", "Orange", 34.5, true, 120, false);
Coffee coffee = new Coffee("Latte", "Brownish", 160.1, false, 200,"Light", "Colombian");
Wine wine = new Wine("Sparkling Rose", "Pink", 40.5, true, 75, "Napa Valley", 2008);





List<Drink> AllBeverages = new List<Drink>()
{
soda,
coffee,
wine
};
foreach(Drink d in AllBeverages)
{
    Console.WriteLine(d.ShowDrink());
}