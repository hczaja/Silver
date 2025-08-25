using Core.Interfaces;
using SFML.Graphics;
using SFML.System;

namespace Core.Fields;

public class Field : IDrawable
{
    internal const int Size = 32;
    private readonly RectangleShape _shape;

    public Field(int col, int row)
    {
        XPos = col;
        YPos = row;

        _shape = new FieldShapeFactory().GetRectangleShape(col, row);
    }

    public int XPos { get; }

    public int YPos { get; }

    public void DrawBy(RenderTarget target)
    {
        target.Draw(_shape);
    }
}