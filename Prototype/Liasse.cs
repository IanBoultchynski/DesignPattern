namespace Prototype;

public abstract class Liasse
{
    protected IList<Document> documents = new List<Document>();

    public IList<Document> getDocuments() => documents;

    protected void setDocuments(IList<Document> documents) => this.documents = documents;
}

