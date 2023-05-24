namespace CookieCookbook.FileReaderWriter;

internal interface IFileReaderWriter
{
    public List<string> IngredientIds { get; set; }
    void Write(List<Ingredient> listToWrite);
    void Read();
}
