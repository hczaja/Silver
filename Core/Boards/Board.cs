using Core.Fields;
using Core.Interfaces;
using SFML.Graphics;

namespace Core.Boards;

public class Board : IDrawable
{
    private readonly ILogger _logger;
    private readonly FieldFactory _fieldFactory;

    public readonly Field[,] _fields;

    public Board(ILogger logger, FieldFactory fieldFactory, BoardSize boardSize)
    {
        _logger = logger;
        _fieldFactory = fieldFactory;

        int size = (int)boardSize;

        _fields = new Field[size, size];

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                _fields[col, row] = _fieldFactory.CreateField(col, row);
            }
        }
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
    }
}

