namespace adapter;

public class DocumentPdf : Document
{
    protected ComposantPdf outilPdf = new();

    public void setContenu(string contenu) =>
        outilPdf.pdfFixeContenu(contenu);

    public void dessine()
    {
        outilPdf.pdfPrépareAffichage();
        outilPdf.pdfRafraîchit();
        outilPdf.pdfTermineAffichage();
    }

    public void imprime() =>
        outilPdf.pdfEnvoieImprimante();
}

