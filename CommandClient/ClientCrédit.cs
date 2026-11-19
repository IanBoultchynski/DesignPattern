namespace CommandClient;

public class ClientCrédit : Client
{
    protected override Commande créeCommande()
    {
        return new CommandeCrédit();
    }
}

