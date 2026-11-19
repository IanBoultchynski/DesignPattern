using Décorateur;

VueCatalogue catalogue = new();

ComposantGraphiqueVéhicule vehicule = new VueVéhicule();
Console.WriteLine("--- Véhicule de base ---");
catalogue.afficher(vehicule);

Console.WriteLine("\n--- Véhicule décoré avec le modèle ---");
ComposantGraphiqueVéhicule modele = new ModèleDécorateur(vehicule);
catalogue.afficher(modele);

Console.WriteLine("\n--- Véhicule décoré avec le modèle et la marque ---");
ComposantGraphiqueVéhicule complet = new MarqueDécorateur(modele);
catalogue.afficher(complet);
