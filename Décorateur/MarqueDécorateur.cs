namespace Décorateur;

public class MarqueDécorateur : Décorateur
{
    public MarqueDécorateur(ComposantGraphiqueVéhicule composant) : base(composant)
    {
    }

    protected void afficheLogo() =>
        Console.WriteLine("Logo de la marque");

    public override void affiche()
    {
        base.affiche();
        afficheLogo();
    }
}
