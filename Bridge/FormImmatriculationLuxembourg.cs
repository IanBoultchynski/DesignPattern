namespace Bridge;

public class FormImmatriculationLuxembourg : FormulaireImmatriculation
{
    public FormImmatriculationLuxembourg(FormulaireImpl implantation) : base(implantation)
    {
    }

    protected override bool contrôleSaisie() =>
        contenu.Length <= 5;
}
