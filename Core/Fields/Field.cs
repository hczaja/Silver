using Core.Extensions;
using Core.Interfaces;
using Core.Settings;
using Core.Units;
using SFML.Graphics;
using SFML.System;

namespace Core.Fields;

public class Field : IDrawable, ITargetable
{
    internal const int Size = 32;
    
    private readonly Sprite _sprite;
    private readonly FieldMarker _marker;

    private bool isTargeted;

    public Unit Unit { get; set; }

    public Field(int col, int row, FieldType type, Sprite sprite)
    {
        Id = Guid.NewGuid();

        XPos = col;
        YPos = row;

        Type = type;

        _sprite = sprite;
        _marker = new FieldMarker(sprite.Position);
    }

    public Guid Id { get; }

    public int XPos { get; }

    public int YPos { get; }

    public FieldType Type { get; }

    public FloatRect TargetArea => _sprite.GetGlobalBounds();

    public bool IsForbidden() => Type == FieldType.Invalid || Type == FieldType.Water;

    public void DrawBy(RenderTarget render)
    {
        render.Draw(_sprite);

        if (Unit != null)
        {
            Unit.DrawBy(render);
        }

        if (isTargeted)
        {
            render.Draw(_marker);
        }
    }

    public bool CheckCollisions()
    {
        throw new NotImplementedException();
    }

    internal void SetAsTarget(bool value) => isTargeted = value;

    public override string? ToString()
    {
        string fieldInfo = $"{Type} [" +
            $"X:{XPos}|" +
            $"Y:{YPos}]";

        if (Unit != null)
        {
            string unitInfo = $"[{Unit?.ToString()}]";
            return $"{fieldInfo} ({unitInfo})";
        }

        return fieldInfo;
    }
}