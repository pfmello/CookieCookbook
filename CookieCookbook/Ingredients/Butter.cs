namespace CookieCookbook.Ingredients;

public class Butter : Ingredient
{
    public override int ID => 3;

    public override string Name => "Butter";

    public override void Prepare()
    {
        Console.WriteLine("Melt on low heat.Add to other ingredients.");
    }
}


