namespace Structure;

public class ConstructeurLiasseVéhiculePdf : ConstructeurLiasseVéhicule
{
    public ConstructeurLiasseVéhiculePdf() => liasse = new LiassePdf();

    public override void construitBonDeCommande(string nom) =>
        liasse.AjouteDocument("<PDF>Bon de commande</PDF>");
    
    public override void construitDemandeImmatriculation(string nom) =>
        liasse.AjouteDocument("<PDF>Demande d'immatriculation</PDF>");
}
