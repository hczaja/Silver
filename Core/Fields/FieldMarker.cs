using SFML.Graphics;
using SFML.System;

namespace Core.Fields;

public class FieldMarker : RectangleShape
{
    public FieldMarker(Vector2f position)
    {
        Size = new Vector2f(Field.Size, Field.Size);
        Position = position;

        FillColor = Color.Transparent;

        OutlineColor = Color.Red;
        OutlineThickness = 1;
    }
}
