using SFML.Graphics;
using SFML.System;

namespace Core.Fields;

internal class FieldShapeFactory
{
    internal RectangleShape GetRectangleShape(int x, int y)
    {
        RectangleShape shape = new();

        shape.Position = new Vector2f(x * Field.Size, y * Field.Size);
        shape.Size = new Vector2f(Field.Size, Field.Size);
        shape.FillColor = Color.Black;

        shape.OutlineThickness = 1;
        shape.OutlineColor = Color.White;

        return shape;
    }
}
