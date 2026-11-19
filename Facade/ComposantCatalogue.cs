namespace Facade;

public class ComposantCatalogue : Catalogue
{
    protected object[] descriptionVehicule =
    [
        "Berline 5 portes", 6000,
        "Compacte 3 portes", 4000,
        "Espace 5 portes", 8000,
        "Break luxe", 12000,
        "Coupé sport", 9000,
        "Utilitaire", 5000
    ];

    public IList<string> retrouveVéhicules(int prixMin, int prixMax)
    {
        IList<string> resultat = new List<string>();
        for (int index = 0; index < descriptionVehicule.Length; index += 2)
        {
            int prix = (int)descriptionVehicule[index + 1];
            if (prix >= prixMin && prix <= prixMax)
            {
                resultat.Add((string)descriptionVehicule[index] + $" ({prix} €)");
            }
        }
        return resultat;
    }
}
