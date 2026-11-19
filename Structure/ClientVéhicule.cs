using Structure;
using System;

public class ClientVehicule
{
    static void Main(string[] args)
    {
        ConstructeurLiasseVéhicule constructeur;
        Console.WriteLine("Voulez-vous construire " +
          "des liasses HTML (1) ou PDF (2) :");
        string choix = Console.ReadLine();
        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVéhiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVéhiculePdf();
        }
        Vendeur vendeur = new Vendeur(constructeur);
        Liasse liasse = vendeur.Construit("Martin");
        liasse.Imprime();
    }
}