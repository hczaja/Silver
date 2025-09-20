namespace Core.Factions;

public class FactionInfo
{
    public Faction Faction { get; }

    public string FactionName => Faction.ToString();
}
