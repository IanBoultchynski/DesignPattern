namespace Composite;

public class SociétéMère : Société
{
    protected IList<Société> filiales = new List<Société>();

    public override double calculeCoûtEntretien()
    {
        double cout = nbrVehicules * coutUnitaireVehicule;
        foreach (Société soc in filiales)
        {
            cout += soc.calculeCoûtEntretien();
        }
        return cout;
    }

    public override bool ajouteFiliale(Société filiale)
    {
        filiales.Add(filiale);
        return true;
    }
}
