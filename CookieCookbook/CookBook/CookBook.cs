namespace CookieCookbook.CookBook;
public class Cookbook
{
    public List<Ingredient> AvailableIngredients { get; } = new List<Ingredient>
        {
            new WheatFlour(),
            new CoconutFlour(),
            new Butter(),
            new Chocolate(),
            new Sugar(),
            new Cardamom(),
            new Cinnamon(),
            new CocoaPowder(),
        };

    public List<Ingredient> Recipe { get; set; } = new List<Ingredient>();
    public void ShowAvailableIngredients()
    {
        Console.WriteLine("Create a new cookie recipe ! Available ingredients are: ");

        foreach (Ingredient ingredient in AvailableIngredients)
        {
            Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
        }
    }

    public void AddIngredient()
    {

    }
}