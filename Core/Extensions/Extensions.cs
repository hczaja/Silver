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
}
