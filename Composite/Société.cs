namespace Composite;

public abstract class Société
{
    protected static double coutUnitaireVehicule = 5.0;
    protected int nbrVehicules = 0;

    public void ajouteVéhicule() => nbrVehicules++;

    public abstract double calculeCoûtEntretien();

    public abstract bool ajouteFiliale(Société filiale);
}
