namespace Flyweight;

public class VehiculeCommande
{
    protected IList<OptionVehicule> options = new List<OptionVehicule>();
    protected IList<int> prixDeVenteOptions = new List<int>();

    public void ajouteOption(string nom, int prixDeVente, FabriqueOption fabrique)
    {
        options.Add(fabrique.getOption(nom));
        prixDeVenteOptions.Add(prixDeVente);
    }

    public void afficheOptions()
    {
        for (int i = 0; i < options.Count; i++)
        {
            options[i].affiche(i + 1, prixDeVenteOptions[i]);
        }
    }
}
