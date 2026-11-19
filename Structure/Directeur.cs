namespace Structure;

public class Directeur(ConstructeurAbstrait constructeur)
{
    public void construit()
    {
        constructeur.construitPart1();
        constructeur.construitPart2();
    }
}
