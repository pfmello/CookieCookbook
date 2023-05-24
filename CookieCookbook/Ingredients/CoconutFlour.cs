namespace CookieCookbook.Ingredients;

public class CoconutFlour : Ingredient
{
    public override int ID => 2;

    public override string Name => "Coconut Flour";

    public override void Prepare()
    {
        Console.WriteLine("Sieve. Add to other ingredients.");
    }

}
