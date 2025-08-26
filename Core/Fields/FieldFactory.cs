using Core.Interfaces;
using SFML.Graphics;

namespace Core.Fields;

public class FieldFactory
{
    private readonly ILogger _logger;
    private readonly FieldShapeFactory _shapeFactory;

    public FieldFactory(ILogger logger)
    {
        _logger = logger;
        _shapeFactory = new FieldShapeFactory();
    }

    public Field CreateField(int x, int y)
    {
        _logger.LogDebug($"{nameof(FieldFactory)} - {nameof(CreateField)} at {x}, {y}");
        
        RectangleShape shape = _shapeFactory.GetRectangleShape(x, y);

        Field field = new Field(x, y, FieldType.Grass, shape);

        return field;
    }
}
