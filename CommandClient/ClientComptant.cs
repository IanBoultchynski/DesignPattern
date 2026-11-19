namespace CommandClient;

public class ClientComptant : Client
{
    protected override Commande créeCommande()
    {
        return new CommandeComptant();
    }
}

