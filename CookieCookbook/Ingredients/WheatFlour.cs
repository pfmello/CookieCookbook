namespace CookieCookbook.Ingredients;

public class WheatFlour : Ingredient
{
    public override int ID => 1;

    public override string Name => "Wheat Flour";

    public override void Prepare()
    {
        Console.WriteLine("Sieve. Add to other ingredients.");
    }
}
