namespace Structure;

public class ConstructeurLiasseVéhiculeHtml : ConstructeurLiasseVéhicule
{
    public ConstructeurLiasseVéhiculeHtml() => liasse = new LiasseHtml();

    public override void construitBonDeCommande(string nom) =>
        liasse.AjouteDocument("<HTML>Bon de commande</HTML>");

    public override void construitDemandeImmatriculation(string nom) =>
        liasse.AjouteDocument("<HTML>Demande d'immatriculation</HTML>");
}
