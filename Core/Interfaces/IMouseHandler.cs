using SFML.Window;

namespace Core.Interfaces;

public interface IMouseHandler
{
    void MouseButtonPressed(object? sender, MouseButtonEventArgs e);
    void MouseButtonReleased(object? sender, MouseButtonEventArgs e);
    void MouseMoved(object? sender, MouseMoveEventArgs e);
}
