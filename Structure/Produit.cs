namespace Structure;

public class Produit
{
    private readonly List<string> _parties = new();

    public void Ajoute(string partie) => _parties.Add(partie);
    public void Affiche() => Console.WriteLine("Produit : " + string.Join(", ", _parties));
}
