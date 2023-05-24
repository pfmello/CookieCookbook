namespace CookieCookbook.FileReaderWriter;

internal class TxtFileReaderWriter : IFileReaderWriter
{
    public List<string> IngredientIds { get; set; } = new List<string>();

    public TxtFileReaderWriter()
    {
        if (File.Exists(@"C:\Games\teste.txt")) {

            string currentRecipe = File.ReadAllText(@"C:\Games\teste.txt");

            if (currentRecipe.Length > 0)
            {
                var ids = currentRecipe.Split(Environment.NewLine);
                foreach (var id in ids)
                {
                    IngredientIds.Add(id);
                }
            } else
            {
                File.Create(@"C:\Games\teste.txt");
            }
        }
    }

    public void Read()
    {
        //string data;
        //StreamReader reader = new StreamReader(@"C:\Games\teste.txt");
        //data = reader.ReadLine();

        //while (data is not null)
        //{
        //    Console.WriteLine(data);
        //    data = reader.ReadLine();
        //}

        //reader.Close();

        string recipeString = File.ReadAllText(@"C:\Games\teste.txt");
        Console.WriteLine(recipeString);
    }

    public void Write(List<Ingredient> listToWrite)
    {
        StreamWriter writer = new StreamWriter(@"C:\Games\teste.txt");
        string ingredients = "";

        foreach (var ingredient in listToWrite)
        {
            ingredients += ingredient.ID + ",";
        }

        IngredientIds.Add(ingredients);

        foreach (var ingredient in IngredientIds)
        {
            writer.WriteLine(ingredient);
        }

        writer.Close();
    }
}
