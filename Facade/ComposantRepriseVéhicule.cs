namespace Facade;

public class ComposantRepriseVéhicule : RepriseVéhicule
{
    public string reprise(string description) =>
        $"Offre de reprise pour : {description}";
}
