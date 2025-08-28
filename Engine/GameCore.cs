using Core.Boards;
using Core.Fields;
using Core.Interfaces;
using Core.Logs;
using Core.Tools;
using SFML.Graphics;
using SFML.Window;

namespace Engine;

internal class GameCore
{
    public readonly Board _board;

    public GameCore()
    {
        ILogger logger = new ConsoleLogger();
        _board = new Board(
            logger,
            new FieldFactory(logger),
            BoardSize.Small);
    }

    internal void KeyPressed(object? sender, KeyEventArgs e)
    {
        throw new NotImplementedException();
    }

    internal void KeyReleased(object? sender, KeyEventArgs e)
    {
        throw new NotImplementedException();
    }

    internal void MouseButtonPressed(object? sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }

    internal void MouseButtonReleased(object? sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }

    internal void Render(RenderTarget target)
    {
        _board.DrawBy(target);
    }

    internal void Update()
    {
        
    }
}
