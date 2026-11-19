namespace Flyweight;

public class OptionVehicule
{
    protected string nom;
    protected string description;
    protected int prixStandard;

    public OptionVehicule(string nom)
    {
        this.nom = nom;
        this.description = $"Description de {nom}";
        this.prixStandard = 100;
    }

    public void affiche(int position, int prixDeVente)
    {
        Console.WriteLine($"Option {nom} à la position {position} : {description}");
        Console.WriteLine($"  Prix standard : {prixStandard} € | Prix de vente : {prixDeVente} €");
    }
}
