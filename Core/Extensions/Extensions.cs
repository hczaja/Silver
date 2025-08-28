using SFML.System;

namespace Core.Extensions;

public static class Extensions
{
    public static Vector2i ToVector2i(this Vector2f v)
        => new Vector2i((int)v.X, (int)v.Y);
}
