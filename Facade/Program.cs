using Facade;

WebServiceAuto webService = new WebServiceAutoImpl();

Console.WriteLine("Recherche de véhicules autour de 7000 € (écart +/- 2000 €) :");
IList<string> vehicules = webService.chercheVéhicules(7000, 2000);

foreach (string vehicule in vehicules)
{
    Console.WriteLine($" - {vehicule}");
}
