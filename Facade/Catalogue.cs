namespace Facade;

public interface Catalogue
{
    IList<string> retrouveVéhicules(int prixMin, int prixMax);
}
