using Core.Events;
using Core.Interfaces;
using SFML.System;

namespace Core.Extensions;

public static class Extensions
{
    public static Vector2i ToVector2i(this Vector2f v)
        => new Vector2i((int)v.X, (int)v.Y);

    public static Vector2f Normalized(this Vector2f v)
    {
        float magnitude = MathF.Sqrt(v.X * v.X + v.Y * v.Y);
        return new Vector2f(v.X / magnitude, v.Y / magnitude);
    }

    public static bool IsMouseEventRaisedIn(this MouseEvent e, ITargetable target, Vector2f offset = default)
    {
        float mouseX = e.X + offset.X;
        float mouseY = e.Y + offset.Y;

        return 
           target.TargetArea.Left < mouseX  && mouseX < target.TargetArea.Left + target.TargetArea.Width
        && target.TargetArea.Top < mouseY && mouseY < target.TargetArea.Top + target.TargetArea.Height;
    }
}
