namespace Flyweight;

public class FabriqueOption
{
    protected IDictionary<string, OptionVehicule> options = new Dictionary<string, OptionVehicule>();

    public OptionVehicule getOption(string nom)
    {
        if (options.ContainsKey(nom))
        {
            return options[nom];
        }
        else
        {
            OptionVehicule nouvelleOption = new OptionVehicule(nom);
            options.Add(nom, nouvelleOption);
            return nouvelleOption;
        }
    }
}
