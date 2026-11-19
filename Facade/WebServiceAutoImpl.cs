namespace Facade;

public class WebServiceAutoImpl : WebServiceAuto
{
    protected Catalogue catalogue = new ComposantCatalogue();
    protected GestionDocument gestionDocument = new ComposantGestionDocument();
    protected RepriseVéhicule repriseVéhicule = new ComposantRepriseVéhicule();

    public IList<string> chercheVéhicules(int prixMoyen, int écartMax)
    {
        return catalogue.retrouveVéhicules(prixMoyen - écartMax, prixMoyen + écartMax);
    }
}
