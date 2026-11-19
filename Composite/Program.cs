using Composite;

Société societe1 = new SociétéSansFiliale();
societe1.ajouteVéhicule();
societe1.ajouteVéhicule();

Société societe2 = new SociétéSansFiliale();
societe2.ajouteVéhicule();

Société groupe = new SociétéMère();
groupe.ajouteVéhicule();
groupe.ajouteFiliale(societe1);
groupe.ajouteFiliale(societe2);

Console.WriteLine($"Coût filiale 1 : {societe1.calculeCoûtEntretien()}");
Console.WriteLine($"Coût filiale 2 : {societe2.calculeCoûtEntretien()}");
Console.WriteLine($"Coût total groupe : {groupe.calculeCoûtEntretien()}");
