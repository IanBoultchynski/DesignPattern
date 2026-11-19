namespace Prototype;

public class LiasseClient : Liasse
{
    public void crée(string informations)
    {
        documents = new List<Document>();
        foreach (Document doc in LiasseVierge.Instance().getDocuments())
        {
            Document copie = doc.duplique();
            copie.remplit(informations);
            documents.Add(copie);
        }
    }

    public void affiche()
    {
        foreach (Document doc in documents)
            doc.affiche();
    }

    public void imprime()
    {
        foreach (Document doc in documents)
            doc.imprime();
    }
}

