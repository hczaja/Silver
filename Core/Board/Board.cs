namespace Core.Board;

internal enum BoardSize
{
    Small = 16,
    Medium = 32,
    Large = 48,
    ExtraLarge = 64,
}

internal class Board
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
}

internal class Field
{
    public Field(int col, int row) 
        => (XPos, YPos) = (col, row);

    public int XPos { get; }

    public int YPos { get; }
}
