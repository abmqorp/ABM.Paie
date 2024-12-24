namespace ABM.Paie.Models;

public class Quote(string author, string text)
{
    public string Author { get; } = author;
    public string Text { get; } = text;
}
