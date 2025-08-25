using Core.Interfaces;
using SFML.Graphics;
using SFML.System;

namespace Core.Fields;

public class Field : IDrawable
{
    const int Size = 32;
    private readonly RectangleShape _shape;

    public Field(int col, int row)
    {
        XPos = col;
        YPos = row;

        _shape = new RectangleShape();
        _shape.Position = new Vector2f(XPos * Size, YPos * Size);
        _shape.Size = new Vector2f(Size, Size);
        _shape.FillColor = Color.Black;

        _shape.OutlineThickness = 1;
        _shape.OutlineColor = Color.White;
    }

    public int XPos { get; }

    public int YPos { get; }

    public void DrawBy(RenderTarget target)
    {
        target.Draw(_shape);
    }
}