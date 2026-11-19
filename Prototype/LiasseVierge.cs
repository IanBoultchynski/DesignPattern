namespace Prototype;

public class LiasseVierge : Liasse
{
    private static LiasseVierge? _instance;

    private LiasseVierge()
    {
    }

    public static LiasseVierge Instance() => _instance ??= new LiasseVierge();

    public void ajoute(Document doc) => documents.Add(doc);

    public void retire(Document doc) => documents.Remove(doc);
}

