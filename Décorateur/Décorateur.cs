namespace Décorateur;

public abstract class Décorateur : ComposantGraphiqueVéhicule
{
    protected ComposantGraphiqueVéhicule composant;

    public Décorateur(ComposantGraphiqueVéhicule composant)
    {
        this.composant = composant;
    }

    public virtual void affiche() => composant.affiche();
}
