namespace Bridge;

public class FormHtmlImpl : FormulaireImpl
{
    public void dessineTexte(string texte) =>
        Console.WriteLine($"HTML : {texte}");

    public string gèreZoneSaisie() =>
        Console.ReadLine() ?? string.Empty;
}
