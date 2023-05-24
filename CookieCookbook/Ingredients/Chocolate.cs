namespace CookieCookbook.Ingredients;

public class Chocolate : Ingredient
{
    public override int ID => 4;

    public override string Name => "Chocolate";

    public override void Prepare()
    {
        Console.WriteLine("Melt in a water bath. Add to other ingredients.");
    }
}


