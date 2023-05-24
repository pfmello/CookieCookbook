namespace CookieCookbook.Ingredients;

public class Cinnamon : Ingredient
{
    public override int ID => 7;

    public override string Name => "Cinnamon";

    public override void Prepare()
    {
        Console.WriteLine("Take half a teaspoon. Add to other ingredients.");
    }
}


