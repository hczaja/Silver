using Core.Interfaces;
using Core.Tools;
using SFML.Graphics;
using SFML.System;
using System.Security.Cryptography;

namespace Core.Fields;

public class FieldFactory
{
    private readonly ILogger _logger;
    private readonly ResourceLoader _resourceLoader;

    public FieldFactory(ILogger logger)
    {
        _logger = logger;
        _resourceLoader = new ResourceLoader();
    }

    public Field CreateField(int x, int y)
    {
        int r = RandomNumberGenerator.GetInt32(3);
        FieldType fieldType = (FieldType)Enum.GetValues(typeof(FieldType)).GetValue(r);

        _logger.LogDebug($"{nameof(FieldFactory)} - {nameof(CreateField)} at {x}, {y} - {fieldType}");

        Sprite sprite = _resourceLoader.GetFieldSprite(fieldType);
        sprite.Position = new Vector2f(x * Field.Size, y * Field.Size);

        Field field = new Field(x, y, fieldType, sprite);

        return field;
    }
}
