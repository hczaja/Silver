using Core.Interfaces;
using SFML.Graphics;

namespace Core.Fields;

public class Field : IDrawable
{
    internal const int Size = 32;
    private readonly RectangleShape _shape;

    public Field(int col, int row, FieldType type, RectangleShape shape)
    {
        XPos = col;
        YPos = row;
        _shape = shape;
    }

    public int XPos { get; }

    public int YPos { get; }

    public FieldType Type { get; }

    public bool IsForbidden() => Type == FieldType.Invalid || Type == FieldType.Water;

    public void DrawBy(RenderTarget target)
    {
        target.Draw(_shape);
    }
}