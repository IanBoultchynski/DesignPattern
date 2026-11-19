namespace Structure;

public class ConstructeurConcret : ConstructeurAbstrait
{
    private readonly Produit produit = new();

    public override void construitPart1() => produit.Ajoute("Partie 1");
    public override void construitPart2() => produit.Ajoute("Partie 2");
    public override Produit getProduit() => produit;
}
