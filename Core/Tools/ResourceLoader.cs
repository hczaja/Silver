using Core.Fields;
using Core.Units;
using SFML.Graphics;

namespace Core.Tools;

public class ResourceLoader
{
    public Texture GetTexture(string path)
        => new Texture(path);

    private IDictionary<FieldType, (int, int)> fieldSpritesheet = new Dictionary<FieldType, (int, int)>
    {
        { FieldType.Dirt, (0, 0) },
        { FieldType.Ice, (1, 0) },
        { FieldType.Water, (2, 0) },
        { FieldType.Grass, (3, 0) },
        { FieldType.Swamp, (0, 1) },
        { FieldType.Sand, (1, 1) },
        { FieldType.Rocks, (2, 1) },
        { FieldType.Invalid, (3, 1) },
    };

    private IDictionary<UnitType, int> unitSpritesheet = new Dictionary<UnitType, int>
    {
        { UnitType.Swordsman, 0 }
    };

    public Sprite GetFieldSprite(FieldType type)
    {
        Texture spritesheet = GetTexture("Resources/Spritesheets/fields.png");

        (int col, int row) = fieldSpritesheet[type];
        Sprite sprite = GetSpriteFromTexture(spritesheet, Field.Size, col, row);

        return sprite;
    }

    public Sprite GetUnitSprite(UnitType unitType, int playerId)
    {
        Texture spritesheet = GetTexture("Resources/Spritesheets/units.png");

        int row = unitSpritesheet[unitType];
        Sprite sprite = GetSpriteFromTexture(spritesheet, Field.Size, playerId, row);

        return sprite;
    }

    public Sprite GetSpriteFromTexture(Texture spritesheet, int size, int column, int row)
    {
        Sprite sprite = new Sprite(spritesheet);
        sprite.TextureRect = new IntRect(column * size, row * size, size, size);

        return sprite;
    }
}
