namespace CookieCookbook.Ingredients;

public class CocoaPowder : Ingredient
{
    public override int ID => 8;

    public override string Name => "Cocoa Powder";

    public override void Prepare()
    {
        Console.WriteLine("Add to other ingredients");
    }
}


