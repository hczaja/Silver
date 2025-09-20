using Core.Events;
using Core.Extensions;
using Core.Fields;
using Core.Interfaces;
using Core.Units;
using SFML.Graphics;
using SFML.Window;

namespace Core.Boards;

public class Board : IDrawable, IEventHandler<MouseEvent>
{
    private readonly ICamera _camera;
    private readonly ILogger _logger;
    private readonly FieldFactory _fieldFactory;
    private readonly UnitFactory _unitFactory;

    public readonly Field[,] _fields;
    private Field _targetField = null;

    public Board(
        FieldFactory fieldFactory,
        UnitFactory unitFactory,
        BoardSize boardSize,
        ICamera camera,
        ILogger logger)
    {
        _fieldFactory = fieldFactory;
        _unitFactory = unitFactory;

        int size = (int)boardSize;

        _fields = new Field[size, size];

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                _fields[col, row] = _fieldFactory.CreateField(col, row);
            }
        }

        var startingField = _fields[2, 2];
        var swordsman = _unitFactory.CreateSwordsman(
            startingField.XPos,
            startingField.YPos, 
            0);
        startingField.Unit = swordsman;

        _camera = camera;
        _logger = logger;
    }

    public void DrawBy(RenderTarget target)
    {
        int size = _fields.GetLength(0);

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                _fields[col,row].DrawBy(target);
            }
        }

        _targetField?.DrawBy(target);
    }

    public void Handle(MouseEvent @event)
    {
        if (@event.Type != MouseEventType.ButtonPressed)
            return;

        if (@event.Button != Mouse.Button.Left)
            return;

        int size = _fields.GetLength(0);

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                Field field = _fields[col, row];
                if (@event.IsMouseEventRaisedIn(field, _camera.CameraOffset))
                {
                    _logger.LogInfo($"{_targetField} is replaced with {field}");

                    _targetField?.SetAsTarget(false);
                    _targetField = field;
                    _targetField.SetAsTarget(true);
                }
            }
        }
    }
}

