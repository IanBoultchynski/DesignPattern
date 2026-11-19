namespace Structure;

public abstract class ConstructeurLiasseVéhicule
{
    protected Liasse liasse = null!;

    public abstract void construitBonDeCommande(string nom);
    public abstract void construitDemandeImmatriculation(string nom);
    public Liasse résultat() => liasse;
}
