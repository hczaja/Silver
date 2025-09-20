using Core.Fields;
using Core.Interfaces;
using Core.Tools;
using SFML.Graphics;
using SFML.System;

namespace Core.Units;

public class UnitFactory
{
    private readonly ILogger _logger;
    private readonly ResourceLoader _resourceLoader;

    public UnitFactory(ILogger logger)
    {
        _logger = logger;
        _resourceLoader = new ResourceLoader();
    }

    public Swordsman CreateSwordsman(int x, int y, int playerId)
    {
        UnitType unitType = UnitType.Swordsman;

        _logger.LogDebug($"{nameof(UnitFactory)} - {nameof(CreateSwordsman)} at {x}, {y} - {unitType}");

        Sprite sprite = _resourceLoader.GetUnitSprite(unitType, playerId);
        sprite.Position = new Vector2f(x * Field.Size, y * Field.Size);

        Swordsman swordsman = new Swordsman(x, y, sprite);

        return swordsman;
    }
}
