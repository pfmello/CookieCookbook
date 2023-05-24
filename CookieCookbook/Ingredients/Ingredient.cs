namespace CookieCookbook.Ingredients;

public abstract class Ingredient
{
    public abstract int ID { get; }
    public abstract string Name { get; }
    public abstract void Prepare();

    public override string ToString()
    {
        return $"{ID}. {Name}";
    }
}
