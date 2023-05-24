global using CookieCookbook.Enums;
global using CookieCookbook.Ingredients;
global using CookieCookbook.CookBook;

const string FileName = "recipes";
FileFormat format = FileFormat.Json;

Cookbook cookbook = new Cookbook();
cookbook.ShowAvailableIngredients();


Console.ReadKey();

