namespace Décorateur;

public class ModèleDécorateur : Décorateur
{
    public ModèleDécorateur(ComposantGraphiqueVéhicule composant) : base(composant)
    {
    }

    protected void afficheInfosTechniques() =>
        Console.WriteLine("Informations techniques du modèle");

    public override void affiche()
    {
        base.affiche();
        afficheInfosTechniques();
    }
}
