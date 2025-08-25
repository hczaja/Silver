using Core.Fields;
using Core.Interfaces;
using SFML.Graphics;

namespace Core.Boards;

public class Board : IDrawable
{
    public readonly Field[,] _fields;

    public Board(BoardSize boardSize)
    {
        int size = (int)boardSize;

        _fields = new Field[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                _fields[i, j] = new Field(i, j);
            }
        }
    }

    public void DrawBy(RenderTarget target)
    {
        int size = _fields.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                _fields[i,j].DrawBy(target);
            }
        }
    }
}

