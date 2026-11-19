namespace Bridge;

public abstract class FormulaireImmatriculation
{
    protected string contenu = string.Empty;
    protected FormulaireImpl implantation;

    public FormulaireImmatriculation(FormulaireImpl implantation)
    {
        this.implantation = implantation;
    }

    public void affiche() =>
        implantation.dessineTexte("Numéro d'immatriculation : ");

    public void génèreDocument()
    {
        implantation.dessineTexte("Demande d'immatriculation");
        implantation.dessineTexte($"numéro d'immatriculation : {contenu}");
    }

    public bool gèreSaisie()
    {
        contenu = implantation.gèreZoneSaisie();
        return contrôleSaisie();
    }

    protected abstract bool contrôleSaisie();
}
