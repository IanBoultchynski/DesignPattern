namespace Structure;

public class LiasseHtml : Liasse
{
    public override void AjouteDocument(string document) => contenu.Add(document);

    public override void Imprime()
    {
        Console.WriteLine("Liasse HTML :");
        contenu.ForEach(Console.WriteLine);
    }
}
