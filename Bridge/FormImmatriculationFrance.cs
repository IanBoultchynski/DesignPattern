namespace Bridge;

public class FormImmatriculationFrance : FormulaireImmatriculation
{
    public FormImmatriculationFrance(FormulaireImpl implantation) : base(implantation)
    {
    }

    protected override bool contrôleSaisie() =>
        contenu.Length == 7;
}
