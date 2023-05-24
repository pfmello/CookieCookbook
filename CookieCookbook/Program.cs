global using CookieCookbook.Enums;
global using CookieCookbook.Ingredients;
global using CookieCookbook.CookBook;
global using CookieCookbook.FileReaderWriter;


const string FileName = "recipes";
FileFormat format = FileFormat.Txt;

Cookbook cookbook = new Cookbook();
cookbook.ShowAvailableIngredients();

cookbook.RequestIngredientsId();

if (cookbook.Recipe.Count > 0)
{
    cookbook.PrintRecipe();
    TxtFileReaderWriter txtFiles = new TxtFileReaderWriter();
    txtFiles.Write(cookbook.Recipe);
}
else
    Console.WriteLine("No ingredients have been selected. Recipe will not be saved");

Console.WriteLine("Press any key to close.");
Console.ReadKey();