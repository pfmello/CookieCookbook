namespace CookieCookbook.Ingredients;

public class Cardamom : Ingredient
{
    public override int ID => 6;

    public override string Name => "Cardamom";

    public override void Prepare()
    {
        Console.WriteLine("Take half a teaspoon. Add to other ingredients.");
    }
}


