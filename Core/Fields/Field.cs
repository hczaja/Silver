using Core.Interfaces;
using SFML.Graphics;

namespace Core.Fields;

public class Field : IDrawable
{
    internal const int Size = 32;
    private readonly Sprite _sprite;

    public Field(int col, int row, FieldType type, Sprite sprite)
    {
        XPos = col;
        YPos = row;
        _sprite = sprite;
    }

    public int XPos { get; }

    public int YPos { get; }

    public FieldType Type { get; }

    public bool IsForbidden() => Type == FieldType.Invalid || Type == FieldType.Water;

    public void DrawBy(RenderTarget target)
    {
        target.Draw(_sprite);
    }
}