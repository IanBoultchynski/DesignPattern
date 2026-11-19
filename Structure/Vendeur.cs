namespace Structure
{
    public class Vendeur
    {
        private readonly ConstructeurLiasseVéhicule _constructeur;

        public Vendeur(ConstructeurLiasseVéhicule constructeur)
        {
            _constructeur = constructeur;
        }

        public Liasse Construit(string nomClient)
        {
            _constructeur.construitBonDeCommande(nomClient);
            _constructeur.construitDemandeImmatriculation(nomClient);
            return _constructeur.résultat();
        }
    }
}
