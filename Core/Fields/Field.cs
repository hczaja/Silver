using Core.Collisions;
using Core.Interfaces;
using Core.Settings;
using SFML.Graphics;
using SFML.System;

namespace Core.Fields;

public class Field : IDrawable, ICollidable
{
    internal const int Size = 32;
    
    private readonly Sprite _sprite;
    private readonly CollisionBox _collisionBox;

    public Field(int col, int row, FieldType type, Sprite sprite)
    {
        Id = Guid.NewGuid();

        XPos = col;
        YPos = row;
        _sprite = sprite;
        _collisionBox = new CollisionBox(
            new Vector2f(Size, Size), _sprite.Position, Id);
    }

    public Guid Id { get; }

    public int XPos { get; }

    public int YPos { get; }

    public FieldType Type { get; }

    public bool IsForbidden() => Type == FieldType.Invalid || Type == FieldType.Water;

    public void DrawBy(RenderTarget target)
    {
        target.Draw(_sprite);

        if (Toggles.ShowCollisions)
        {
            target.Draw(_collisionBox);
        }
    }

    public bool CheckCollisions()
    {
        throw new NotImplementedException();
    }
}