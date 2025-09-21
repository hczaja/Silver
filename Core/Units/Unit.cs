using Core.Interfaces;
using Core.Units.Actions;
using SFML.Graphics;

namespace Core.Units;

public abstract class Unit : IDrawable, ITargetable
{
    public abstract FloatRect TargetArea { get; }
    public abstract UnitStatistics Statistics { get; }

    public abstract IEnumerable<ActionType> Actions { get; }
    public abstract void DrawBy(RenderTarget render);
}
