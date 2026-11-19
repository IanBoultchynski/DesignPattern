namespace Structure;

public abstract class Liasse
{
    protected readonly List<string> contenu = new();

    public abstract void AjouteDocument(string document);
    public abstract void Imprime();
}
