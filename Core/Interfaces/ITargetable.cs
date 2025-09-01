using SFML.Graphics;

namespace Core.Interfaces;

public interface ITargetable
{
    public FloatRect TargetArea { get; }
}
