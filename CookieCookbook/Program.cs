using CookieCookbook.Enums;
using CookieCookbook.Ingredients;

const string FileName = "recipes";
FileFormat format = FileFormat.Json;

List<Ingredient> availableIngredients = new List<Ingredient>
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

foreach (Ingredient ingredient in availableIngredients)
{
    Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
    Console.WriteLine("=======");
    ingredient.Prepare();
    Console.WriteLine("=======");
}


Console.ReadKey();
