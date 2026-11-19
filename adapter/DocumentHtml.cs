namespace adapter;

public class DocumentHtml : Document
{
    protected string contenu = string.Empty;

    protected string getContenu() => contenu;

    public void setContenu(string contenu) => this.contenu = contenu;

    public void dessine() =>
        Console.WriteLine($"Dessine document HTML : {contenu}");

    public void imprime() =>
        Console.WriteLine($"Imprime document HTML : {contenu}");
}

