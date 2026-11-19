namespace adapter;

public class ComposantPdf
{
    protected string contenu = string.Empty;

    public void pdfFixeContenu(string contenu) => this.contenu = contenu;

    public void pdfPrépareAffichage() =>
        Console.WriteLine("Affichage PDF : Début");

    public void pdfRafraîchit() =>
        Console.WriteLine($"Affichage contenu PDF : {contenu}");

    public void pdfTermineAffichage() =>
        Console.WriteLine("Affichage PDF : Fin");

    public void pdfEnvoieImprimante() =>
        Console.WriteLine($"Impression PDF : {contenu}");
}

