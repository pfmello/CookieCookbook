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

    public void AddIngredient(int id)
    {
        foreach (var ingredient in AvailableIngredients)
        {
            if (ingredient.ID == id)
            {
                Recipe.Add(ingredient);
                Console.WriteLine($"Added {ingredient.Name}");
            }

        }
    }

    public void RequestIngredientsId()
    {
        string input;
        bool validId;
        int id;

        do
        {
            Console.WriteLine("Add an ingredient by it's Id or type anything else if finished");
            input = Console.ReadLine();

            validId = int.TryParse(input, out id) && id >= 1 && id <= 8;

            if (validId) AddIngredient(id);
            
        } while (validId);

    }

    public void PrintRecipe()
    {
        Console.WriteLine("Recipe added:");

        foreach (var ingredient in Recipe)
        {
            Console.WriteLine(ingredient);
            ingredient.Prepare();
        }
    }

}