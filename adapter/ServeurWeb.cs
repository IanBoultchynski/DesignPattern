namespace adapter;

public class ServeurWeb
{
    public void traiter(Document document, string contenu)
    {
        document.setContenu(contenu);
        document.dessine();
        document.imprime();
    }
}

