namespace Facade;

public class ComposantGestionDocument : GestionDocument
{
    public string document(int index) =>
        $"Document numéro {index}";
}
