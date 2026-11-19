namespace Structure;

public class LiassePdf : Liasse
{
    public override void AjouteDocument(string document) => contenu.Add(document);

    public override void Imprime()
    {
        Console.WriteLine("Liasse PDF :");
        contenu.ForEach(Console.WriteLine);
    }
}
