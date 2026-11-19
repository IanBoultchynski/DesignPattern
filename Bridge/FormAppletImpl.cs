namespace Bridge;

public class FormAppletImpl : FormulaireImpl
{
    public void dessineTexte(string texte) =>
        Console.WriteLine($"Applet : {texte}");

    public string gèreZoneSaisie() =>
        Console.ReadLine() ?? string.Empty;
}
