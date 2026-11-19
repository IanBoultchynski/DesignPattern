using Prototype;

LiasseVierge liasseVierge = LiasseVierge.Instance();
liasseVierge.ajoute(new BonDeCommande());
liasseVierge.ajoute(new CertificatCession());
liasseVierge.ajoute(new DemandeImmatriculation());

LiasseClient liasseClient1 = new();

liasseClient1.crée("Jean Dupont");
liasseClient1.affiche();

Console.WriteLine();

LiasseClient liasseClient2 = new();
liasseClient2.crée("Marie Curie");
liasseClient2.imprime();

