using Flyweight;

FabriqueOption fabrique = new();

VehiculeCommande vehicule1 = new();
vehicule1.ajouteOption("Climatisation", 500, fabrique);
vehicule1.ajouteOption("GPS", 300, fabrique);
vehicule1.ajouteOption("Toit ouvrant", 800, fabrique);

Console.WriteLine("--- Options du Véhicule 1 ---");
vehicule1.afficheOptions();

Console.WriteLine();

VehiculeCommande vehicule2 = new();
// Climatisation et GPS sont partagés via la fabrique Flyweight (mêmes instances partagées)
vehicule2.ajouteOption("Climatisation", 450, fabrique);
vehicule2.ajouteOption("GPS", 320, fabrique);

Console.WriteLine("--- Options du Véhicule 2 ---");
vehicule2.afficheOptions();
