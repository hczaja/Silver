using Core.Factions;
using SFML.Graphics;

namespace Core.Players;

public class Player
{
    public int Id { get; }

    public FactionInfo FactionInfo { get; }
    public Color Color { get; }

}
