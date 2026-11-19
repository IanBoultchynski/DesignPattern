namespace Composite;

public class SociétéSansFiliale : Société
{
    public override double calculeCoûtEntretien() =>
        nbrVehicules * coutUnitaireVehicule;

    public override bool ajouteFiliale(Société filiale) =>
        false;
}
