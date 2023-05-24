namespace CookieCookbook.Ingredients;

public class Sugar : Ingredient
{
    public override int ID => 5;

    public override string Name => "Sugar";

    public override void Prepare()
    {
        Console.WriteLine("Add to other ingredients.");
    }
}


