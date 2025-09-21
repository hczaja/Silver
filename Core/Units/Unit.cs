using Core.Interfaces;
using SFML.Graphics;

namespace Core.Units;

public abstract class Unit : IDrawable, ICollidable, ITargetable
{
    public abstract FloatRect TargetArea { get; }
    public abstract UnitStatistics Statistics { get; }

    public abstract bool CheckCollisions();
    public abstract void DrawBy(RenderTarget render);
}
