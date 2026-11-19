namespace Prototype;

public abstract class Document
{
    protected string contenu = string.Empty;

    public Document duplique() => (Document)MemberwiseClone();

    public void remplit(string informations) => contenu = informations;

    public abstract void imprime();
    public abstract void affiche();
}

